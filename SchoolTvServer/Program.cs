using Microsoft.EntityFrameworkCore;
using SchoolTvServer.Database;
using SchoolTvServer.Middlewares;
using SchoolTvServer.Services;
using SchoolTvServer.Types.Settings;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ServerSettings>(configuration.GetSection("ServerSettings"));
builder.Services.AddSingleton<GoogleClassroomService>();
builder.Services.AddSingleton<GoogleSheetsService>();
builder.Services.AddSingleton<SchoolFoodService>();
builder.Services.AddSingleton<VasttrafikService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        corsPolicyBuilder =>
        {
            corsPolicyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});
builder.Services.AddHttpLogging(o => {  });

var app = builder.Build();
app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.MapControllers();
app.UseMiddleware<PasswordMiddleware>();

using (IServiceScope scope = app.Services.CreateScope())
{
    IServiceProvider services = scope.ServiceProvider;
    DatabaseContext dbContext = services.GetRequiredService<DatabaseContext>();
    dbContext.Database.EnsureCreated();
    dbContext.Database.Migrate();
}

app.Run();