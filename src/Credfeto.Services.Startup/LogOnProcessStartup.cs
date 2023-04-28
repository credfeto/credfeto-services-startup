using System;
using System.Threading;
using System.Threading.Tasks;
using Credfeto.Services.Startup.Interfaces;
using Credfeto.Services.Startup.Logging;
using Microsoft.Extensions.Logging;

namespace Credfeto.Services.Startup;

public sealed class LogOnProcessStartup : IRunOnStartup
{
    private readonly ILogger<LogOnProcessStartup> _logger;

    public LogOnProcessStartup(ILogger<LogOnProcessStartup> logger)
    {
        this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public ValueTask StartAsync(CancellationToken cancellationToken)
    {
        this._logger.LogStarting();

        return ValueTask.CompletedTask;
    }
}