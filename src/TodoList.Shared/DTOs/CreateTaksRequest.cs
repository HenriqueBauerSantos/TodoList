namespace TodoList.Shared.DTOs;

public class CreateTaksRequest
{
    public string Text { get; set; }
    public DateTime DeadLine { get; set; }
    public TaskStatus Status { get; set; }
}
