using Credfeto.Services.Startup.Interfaces.Tests.Mocks;
using FunFair.Test.Common;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Credfeto.Services.Startup.Interfaces.Tests;

public sealed class DependencyInjectionTests : DependencyInjectionTestsBase
{
    public DependencyInjectionTests(ITestOutputHelper output)
        : base(output: output, dependencyInjectionRegistration: ConfigureServices) { }

    private static IServiceCollection ConfigureServices(IServiceCollection services)
    {
        return services.AddRunOnStartupTask<DummyRunOnStartup>();
    }

    [Fact]
    public void DummyRunOnStartupIsRegistered()
    {
        this.RequireServiceInCollectionFor<IRunOnStartup, DummyRunOnStartup>();
    }
}
