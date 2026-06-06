using Microsoft.Extensions.Logging;

namespace Credfeto.Services.Startup.LoggingExtensions;

internal static partial class StartupServiceLoggingExtensions
{
    [LoggerMessage(EventId = 2, Level = LogLevel.Information, Message = "Starting {serviceName} service...")]
    public static partial void LogStarting(this ILogger<StartupService> logger, string serviceName);
}
