using System.Threading;
using System.Threading.Tasks;
using Credfeto.Services.Startup.Interfaces;

namespace Credfeto.Services.Startup.Interfaces.Tests.Mocks;

public sealed class DummyRunOnStartup : IRunOnStartup
{
    public ValueTask StartAsync(CancellationToken cancellationToken)
    {
        return ValueTask.CompletedTask;
    }
}
