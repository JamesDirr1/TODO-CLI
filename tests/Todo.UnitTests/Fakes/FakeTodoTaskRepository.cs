using Todo.Application.Abstractions;
using Todo.Core;

namespace Todo.UnitTests.Fakes;

public class FakeTodoTaskRepository : ITodoTaskRepository
{
    public List<TodoTask> Tasks { get; } = [];

    public void Add(TodoTask task)
    {
        Tasks.Add(task);
    }
}