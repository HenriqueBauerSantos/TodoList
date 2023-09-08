namespace TodoList.Shared.DTOs;

public class CreatedTaskResponse
{
    public Guid Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DeadLine { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }
}
