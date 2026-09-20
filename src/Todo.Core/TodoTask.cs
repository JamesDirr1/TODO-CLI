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
        this.Title = title;
        this.Status = TodoTaskStatus.Open;
    }
    
    public void Complete()
    {
        if (this.Status != TodoTaskStatus.Completed)
        {
            this.Status = TodoTaskStatus.Completed;
        }
    }
}

