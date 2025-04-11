using System.Threading;
using System.Threading.Tasks;

namespace Credfeto.Services.Startup.Interfaces;

public interface IRunOnStartup
{
    ValueTask StartAsync(CancellationToken cancellationToken);
}
