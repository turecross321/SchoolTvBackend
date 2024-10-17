using System.Text.RegularExpressions;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SchoolTvServer.Types;

namespace SchoolTvServer.Services;

public class GoogleSheetsService
{
    private readonly SheetsService _sheets;
    private readonly ILogger _logger;
    private readonly IOptions<ServerSettings> _settings;
    private readonly IMemoryCache _memoryCache;

    public GoogleSheetsService(IOptions<ServerSettings> settings, ILogger<GoogleSheetsService> logger, IMemoryCache memoryCache)
    {
        _settings = settings;
        _logger = logger;
        _memoryCache = memoryCache;

        var serviceAccountKeyFile = settings.Value.GoogleServiceSecretPath;

        var credential = GoogleCredential.FromFile(serviceAccountKeyFile)
            .CreateScoped(new[] { SheetsService.Scope.Spreadsheets });

        _sheets = new SheetsService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = settings.Value.BrandName,
        });
            
        _logger.LogInformation("Google Sheets Service has been initialized.");
    }

    private const string MemoryCacheKey = "GraduationGoals";
    
    public List<GraduationMoneyResponse> GetGraduationGoals()
    {
        List<GraduationMoneyResponse>? cached = _memoryCache.Get<List<GraduationMoneyResponse>>(MemoryCacheKey);
        if (cached != null)
            return cached;
        
        List<GraduationMoneyResponse> response = [];
        
        DateTimeOffset now = DateTimeOffset.Now;
        foreach (var spreadsheet in _settings.Value.GraduationSpreadsheets)
        {
            if (spreadsheet.GraduationDate < now)
            {
                _logger.LogWarning("The graduation goal for a class that is already graduated is still in the config! Skipping...");
                continue;
            }

            if (string.IsNullOrEmpty(spreadsheet.SpreadsheetId))
            {
                _logger.LogWarning($"The graduation goal for {spreadsheet.ClassName} does not have an attached spreadsheet ID.");
                response.Add(new GraduationMoneyResponse
                {
                    ClassName = spreadsheet.ClassName,
                    CurrentAmount = null,
                    Goal = null,
                    GraduationDate = spreadsheet.GraduationDate
                });
                continue;
            }
            
            // TODO: only one lookup would maybe be good??
            int? currentAmount = GetCellNumber(spreadsheet.SpreadsheetId, spreadsheet.CurrentAmountCell);
            int? goal = GetCellNumber(spreadsheet.SpreadsheetId, spreadsheet.GoalCell);

            if (currentAmount == null || goal == null)
            {
                _logger.LogError($"Failed to get current amount and the goal for {spreadsheet.ClassName} -- currentAmount = {currentAmount} goal = {goal}");
                continue;
            }
            
            response.Add(new GraduationMoneyResponse
            {
                ClassName = spreadsheet.ClassName,
                CurrentAmount = (int)currentAmount,
                Goal = (int)goal,
                GraduationDate = spreadsheet.GraduationDate
            });
        }
        
        _memoryCache.Set(MemoryCacheKey, response, TimeSpan.FromHours(1));
        return response;
    }
    
    private int? GetCellNumber(string spreadsheetId, string cell)
    {
        string? raw = GetCellValue(spreadsheetId, cell);
        if (raw == null)
            return null;
        
        _logger.LogTrace($"Fetched {spreadsheetId} {cell} = \"{raw}\"");

        string onlyNumbers = Regex.Replace(raw, "[^0-9]", "");
        if (int.TryParse(onlyNumbers, out int number))
            return number;

        _logger.LogError($"Failed to parse {spreadsheetId} {cell} -- raw value = \"{raw}\"");
        return null;
    }
    
    private string? GetCellValue(string spreadsheetId, string cell)
    {
        try
        {
            // Define request parameters
            SpreadsheetsResource.ValuesResource.GetRequest request = _sheets.Spreadsheets.Values.Get(spreadsheetId, cell);

            // Gets the latest values
            ValueRange response = request.Execute();

            IList<IList<object>> values = response.Values;
            if (values is { Count: > 0 })
            {
                // Assuming the range specifies a single cell or the first cell in a range
                return values[0][0].ToString();
            }
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError("Failed to fetch cell value:" + ex);
            throw;
        }
    }
}