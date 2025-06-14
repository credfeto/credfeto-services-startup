using Microsoft.Extensions.Logging;

namespace Credfeto.Services.Startup.Logging;

internal static partial class StartupServiceLoggerExtensions
{
    [LoggerMessage(EventId = 1, Level = LogLevel.Information, Message = "Starting {serviceName} service...")]
    public static partial void LogStarting(this ILogger<StartupService> logger, string serviceName);
}
