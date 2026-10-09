namespace Todo.Core;

public class TodoTask
{
    public const int MaxTitleLength = 200;

    public TodoTask(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(
                "Title cannot be empty or whitespace.",
                nameof(title));
        }

        if (title.Length > MaxTitleLength)
        {
            throw new ArgumentException(
                $"Title cannot be longer than {MaxTitleLength} characters.", nameof(title));
        }

        Title = title;
        Status = TodoTaskStatus.Open;
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public TodoTaskStatus Status { get; private set; }

    public void Complete()
    {
        if (Status != TodoTaskStatus.Completed)
        {
            Status = TodoTaskStatus.Completed;
        }
    }
}