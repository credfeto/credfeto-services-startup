using System.Threading;
using System.Threading.Tasks;
using Credfeto.Services.Startup.Interfaces;

namespace Credfeto.Services.Startup.Tests.Mocks;

public sealed class Started : IRunOnStartup
{
    private readonly IStarted _started;

    public Started(IStarted started)
    {
        this._started = started;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        return this._started.StartAsync();
    }
}