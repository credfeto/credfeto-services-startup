using System;
using System.Collections.Generic;
using Credfeto.Services.Startup.Interfaces;
using FunFair.Test.Common;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace Credfeto.Services.Startup.Tests;

public sealed class StartupServiceTests : TestBase
{
    [Fact]
    public void ServicesIsRequired()
    {
        ILogger<StartupService> logger = NullLogger<StartupService>.Instance;

        ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() =>
            new StartupService(services: null!, logger: logger)
        );

        Assert.Equal(expected: "services", actual: exception.ParamName);
    }
}
