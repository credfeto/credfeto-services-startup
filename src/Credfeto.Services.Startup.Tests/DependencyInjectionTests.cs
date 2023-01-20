using Credfeto.Services.Startup.Interfaces;
using FunFair.Test.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xunit;
using Xunit.Abstractions;

namespace Credfeto.Services.Startup.Tests;

public sealed class DependencyInjectionTests : DependencyInjectionTestsBase
{
    public DependencyInjectionTests(ITestOutputHelper output)
        : base(output: output, dependencyInjectionRegistration: ConfigureServices)
    {
    }

    private static IServiceCollection ConfigureServices(IServiceCollection serviceCollection)
    {
        return serviceCollection.AddRunOnStartupServices();
    }

    [Fact]
    public void StartupServiceIsRegistered()
    {
        this.RequireServiceInCollectionFor<IHostedService, StartupService>();
    }

    [Fact]
    public void LogOnProcessStartupIsRegistered()
    {
        this.RequireServiceInCollectionFor<IRunOnStartup, LogOnProcessStartup>();
    }
}