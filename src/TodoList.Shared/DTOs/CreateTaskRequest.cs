namespace TodoList.Shared.DTOs;

public class CreateTaskRequest
{
    public string? Text { get; set; }
    public DateTime? Deadline { get; set; }
    public TaskStatus? Status { get; set; }
}