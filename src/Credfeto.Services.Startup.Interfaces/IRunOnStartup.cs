using System.Threading;
using System.Threading.Tasks;

namespace Credfeto.Services.Startup.Interfaces;

public interface IRunOnStartup
{
    Task StartAsync(CancellationToken cancellationToken);
}