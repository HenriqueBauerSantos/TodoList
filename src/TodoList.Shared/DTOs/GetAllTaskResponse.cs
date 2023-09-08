using TodoList.Shared.Enums;

namespace TodoList.Shared.DTOs;

public class GetAllTaskResponse
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateTime Deadline { get; set; }
    public required ETaskStatus Status { get; set; }
}