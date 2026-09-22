using Todo.Application.Tasks;
using Todo.Core;
using Todo.UnitTests.Fakes;

namespace Todo.UnitTests;

public class AddTaskServiceTests
{
    [Fact]
    public void AddTask_ShouldAddTaskToRepository()
    {
        // Arrange
        var repository = new FakeTodoTaskRepository();
        var service = new AddTaskService(repository);

        // Act
        service.AddTask("Test Task");

        // Assert
        Assert.Single(repository.Tasks);
        Assert.Equal("Test Task", repository.Tasks[0].Title);
        Assert.Equal(TodoTaskStatus.Open, repository.Tasks[0].Status);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void AddTask_WithInvalidTitle_ShouldThrowArgumentException(string? title)
    {
        // Arrange
        var repository = new FakeTodoTaskRepository();
        var service = new AddTaskService(repository);

        // Act
        Assert.Throws<ArgumentException>(() => service.AddTask(title!));

        // Assert
        Assert.Empty(repository.Tasks);
    }
}