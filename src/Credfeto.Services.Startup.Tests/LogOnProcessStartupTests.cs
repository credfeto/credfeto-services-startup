using System;
using FunFair.Test.Common;
using Xunit;

namespace Credfeto.Services.Startup.Tests;

public sealed class LogOnProcessStartupTests : TestBase
{
    [Fact]
    public void LoggerIsRequired()
    {
        ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() =>
            new LogOnProcessStartup(logger: null!)
        );

        Assert.Equal(expected: "logger", actual: exception.ParamName);
    }
}
