namespace Portfolio.Api.UnitTests;

using Microsoft.Extensions.Logging;

public abstract class TestBase<T>
{
    protected Mock<ILogger<T>> loggerMock = null!;

    [SetUp]
    public virtual void Setup()
    {
        loggerMock = new Mock<ILogger<T>>();
    }
}
