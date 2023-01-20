using Credfeto.Services.Startup.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Credfeto.Services.Startup;

public static class StartupServicesSetup
{
    public static IServiceCollection AddRunOnStartupServices(this IServiceCollection services)
    {
        return services.AddRunOnStartupTask<LogOnProcessStartup>()
                       .AddHostedService<StartupService>();
    }
}