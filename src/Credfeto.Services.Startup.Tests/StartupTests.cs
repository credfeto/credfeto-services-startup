using System;
using System.Threading;
using System.Threading.Tasks;
using Credfeto.Services.Startup.Interfaces;
using Credfeto.Services.Startup.Tests.Mocks;
using FunFair.Test.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSubstitute;
using Xunit;
using Xunit.Abstractions;

namespace Credfeto.Services.Startup.Tests;

public sealed class StartupTests : LoggingTestBase
{
    public StartupTests(ITestOutputHelper output)
        : base(output: output, dependencyInjectionRegistration: RegisterServices)
    {
    }

    private static IServiceCollection RegisterServices(IServiceCollection services)
    {
        return services.AddMockedService<IStarted>()
                       .AddRunOnStartupServices()
                       .AddRunOnStartupTask<Started>();
    }

    [Fact]
    public async Task ShouldStartTaskAsync()
    {
        IStarted started = this.GetServiceFromDependencyInjection<IStarted>();
        IHostedService hs = this.GetServiceFromDependencyInjection<IHostedService>();

        TimeSpan delay = TimeSpan.FromSeconds(1);

        using (CancellationTokenSource cts = new(delay))
        {
            await hs.StartAsync(cts.Token);

            await Task.Delay(delay: delay, cancellationToken: CancellationToken.None);

            await hs.StopAsync(CancellationToken.None);

            await started.Received(1)
                         .StartAsync();
        }
    }
}