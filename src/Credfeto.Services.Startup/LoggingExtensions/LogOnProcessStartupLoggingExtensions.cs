using Microsoft.Extensions.Logging;

namespace Credfeto.Services.Startup.LoggingExtensions;

internal static partial class LogOnProcessStartupLoggingExtensions
{
    [LoggerMessage(EventId = 1, Level = LogLevel.Information, Message = "Starting...")]
    public static partial void LogStarting(this ILogger<LogOnProcessStartup> logger);
}
