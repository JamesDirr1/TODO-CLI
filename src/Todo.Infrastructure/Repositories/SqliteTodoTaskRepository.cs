using Todo.Application.Abstractions;
using Todo.Core;
using Todo.Infrastructure.Persistence;

namespace Todo.Infrastructure.Repositories;

public class SqliteTodoTaskRepository(TodoDbContext dbContext) : ITodoTaskRepository
{
    public void Add(TodoTask task)
    {
        dbContext.TodoTasks.Add(task);
        dbContext.SaveChanges();
    }
}