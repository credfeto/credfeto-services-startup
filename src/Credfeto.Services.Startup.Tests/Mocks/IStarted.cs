using System.Threading;
using System.Threading.Tasks;

namespace Credfeto.Services.Startup.Tests.Mocks;

public interface IStarted
{
    ValueTask StartAsync(CancellationToken cancellationToken);
}
