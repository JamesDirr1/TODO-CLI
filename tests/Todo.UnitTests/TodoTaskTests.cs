using Todo.Core;

namespace Todo.UnitTests;

public class TodoTaskTests
{
    [Fact]
    public void NewTodoTask_InitWithTitleAndOpenStatus()
    {
        // Arrange
        var title = "Test Task";

        // Act
        var task = new TodoTask(title);

        // Assert
        Assert.Equal(title, task.Title);
        Assert.Equal(TodoTaskStatus.Open, task.Status);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void NewTodoTask_WithInvalidTitle_ShouldThrowArgumentException(string? title)
    {
        // Act & Assert 
        Assert.Throws<ArgumentException>(() => new TodoTask(title!));
    }

    [Fact]
    public void TodoTask_UpdateStatusToCompleted()
    {
        // Arrange
        var title = "Test Task";
        var task = new TodoTask(title);

        // Act
        task.Complete();

        // Assert
        Assert.Equal(TodoTaskStatus.Completed, task.Status);
    }

    [Fact]
    public void TodoTask_CompleteMethodDoesNotChangeStatusIfAlreadyCompleted()
    {
        // Arrange
        var title = "Test Task";
        var task = new TodoTask(title);
        task.Complete(); // Set status to Completed

        // Act
        task.Complete(); // Try to complete again

        // Assert
        Assert.Equal(TodoTaskStatus.Completed, task.Status);
    }
}