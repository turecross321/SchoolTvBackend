using Microsoft.Extensions.Options;
using SchoolTvServer.Attributes;
using SchoolTvServer.Types;
using SchoolTvServer.Types.Settings;

namespace SchoolTvServer.Middlewares;

public class PasswordMiddleware(
    RequestDelegate next,
    IOptions<ServerSettings> settings,
    ILogger<PasswordMiddleware> logger)
{

    public async Task InvokeAsync(HttpContext context)
    {
        var endpoint = context.GetEndpoint();
        var passwordAttribute = endpoint?.Metadata.GetMetadata<PasswordTypeAttribute>();

        if (passwordAttribute == null)
        {
            logger.LogWarning($"No authentication type has been assigned to {endpoint}. " +
                              $"Please add {typeof(PasswordTypeAttribute)} to the endpoint. Defaulting to readonly.");
            passwordAttribute = new PasswordTypeAttribute(AccessType.ReadOnly);
        }

        string? providedPassword;

        // If not found in headers, try getting it from the query string
        if (context.Request.Headers.TryGetValue("Password", out var headerPassword))
        {
            providedPassword = headerPassword;
        }
        else
        {
            providedPassword = context.Request.Query["password"].FirstOrDefault();
        }
        
        if (string.IsNullOrEmpty(providedPassword))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("'Password' header or 'password' query required.");
            return;
        }
        
        var requiredPassword = passwordAttribute.AccessType switch
        {
            AccessType.ReadOnly => settings.Value.ReadOnlyPassword,
            AccessType.UploadTemperature => settings.Value.UploadTemperaturePassword,
            _ => throw new ArgumentOutOfRangeException()
        };

        if (providedPassword != requiredPassword)
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Invalid password.");
            return;
        }
        
        await next(context);
    }
}
