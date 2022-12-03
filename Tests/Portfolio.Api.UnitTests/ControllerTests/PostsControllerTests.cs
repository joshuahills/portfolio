namespace Portfolio.Api.UnitTests.ControllerTests;

using Portfolio.Api.Controllers;

public class PostsControllerTests : TestBase<PostsController>
{
    private PostsController controller = null!;

    [SetUp]
    public override void Setup()
    {
        base.Setup();

        controller = new PostsController();
    }

    [Test]
    public void When_GetPost_Called_Should_Return_Post()
    {
        // Arrange

        // Act
        var result = controller.GetPost();

        // Assert
        result.Should().NotBeNull();
    }
}