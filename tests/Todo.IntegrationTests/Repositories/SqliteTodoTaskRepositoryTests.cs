using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Todo.Core;
using Todo.Infrastructure.Persistence;
using Todo.Infrastructure.Repositories;

namespace Todo.IntegrationTests.Repositories;

public class SqliteTodoTaskRepositoryTests
{
    [Fact]
    public void Add_ShouldPersistTaskToDatabase()
    {
        // Arrange
        using var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();

        var options = new DbContextOptionsBuilder<TodoDbContext>()
            .UseSqlite(connection)
            .Options;
        using (var context = new TodoDbContext(options))
        {
            context.Database.EnsureCreated();
        }

        // Act
        using (var context = new TodoDbContext(options))
        {
            var repository = new SqliteTodoTaskRepository(context);
            var task = new TodoTask("Test Task");

            repository.Add(task);
        }

        // Assert
        using (var context = new TodoDbContext(options))
        {
            var savedTask = context.TodoTasks.Single();

            Assert.Equal("Test Task", savedTask.Title);
            Assert.Equal(TodoTaskStatus.Open, savedTask.Status);
            Assert.True(savedTask.Id > 0);
        }
    }
}