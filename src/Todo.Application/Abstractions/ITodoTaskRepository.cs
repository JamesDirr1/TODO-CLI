using Todo.Core;

namespace Todo.Application.Abstractions;

public interface ITodoTaskRepository
{
    void Add(TodoTask task);
}