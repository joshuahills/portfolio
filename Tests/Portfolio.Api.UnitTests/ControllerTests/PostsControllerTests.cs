namespace Portfolio.Api.UnitTests.ControllerTests;

using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Controllers;

public class PostsControllerTests : TestBase<PostsController>
{
    private PostsController controller = null!;

    [SetUp]
    public override void Setup()
    {
        base.Setup();

        //controller = new PostsController();
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

    [Test]
    public void When_GetTestAdAuth_Called_Should_Return_Ok()
    {
        // Arrange

        // Act
       // var result = controller.GetTestAdAuth();

        // Assert
        //result.Should().BeOfType<OkResult>();
    }
}