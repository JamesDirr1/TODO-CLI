using Todo.Application.Abstractions;
using Todo.Core;

namespace Todo.Application.Tasks;

public class AddTaskService(ITodoTaskRepository taskRepository)
{
    public void AddTask(string title)
    {
        var task = new TodoTask(title);
        taskRepository.Add(task);
    }
}