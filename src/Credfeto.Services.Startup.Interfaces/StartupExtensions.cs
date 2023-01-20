using Microsoft.Extensions.DependencyInjection;

namespace Credfeto.Services.Startup.Interfaces;

public static class StartupExtensions
{
    public static IServiceCollection AddRunOnStartupTask<TService>(this IServiceCollection services)
        where TService : class, IRunOnStartup
    {
        return services.AddSingleton<IRunOnStartup, TService>();
    }
}