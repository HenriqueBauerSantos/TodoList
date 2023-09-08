using TodoList.Shared.Enums;

namespace TodoList.Shared.DTOs;

public class CreateTaskRequest
{
    public string? Text { get; set; }
    public DateTime? Deadline { get; set; }
    public ETaskStatus? Status { get; set; }


    public CreateTaskRequest()
    {
    }

    public CreateTaskRequest(string text, DateTime deadline, ETaskStatus status)
    {
        Text = text;
        Deadline = deadline;
        Status = status;
    }
}