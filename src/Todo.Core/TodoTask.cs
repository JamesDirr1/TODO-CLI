namespace Todo.Core;

public class TodoTask
{
    public string Title { get; private set; }
    public TodoTaskStatus Status { get; private set; }
    
    public TodoTask (string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(
                "Title cannot be empty or whitespace.", 
                nameof(title));
        } 
        Title = title;
        Status = TodoTaskStatus.Open;
    }
    
    public void Complete()
    {
        if (Status != TodoTaskStatus.Completed)
        {
            Status = TodoTaskStatus.Completed;
        }
    }
}
