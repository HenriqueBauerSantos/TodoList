namespace TodoList.Front.Services;

public class TaskService
{
    private readonly HttpClient _httpClient = new()
    {
        BaseAddress = new Uri("https://4b59-2804-2984-2d0-4b00-ea55-6ef0-5b15-3cb9.ngrok-free.app/")
    };

    public async Task<ServiceResponse<CreateTaskResponse>> Create(CreateTaskRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(TaskRoutes.Create, request);
        return await ServiceResponse<CreateTaskResponse>.FromHttpMessage(response);
    }

    public async Task<ServiceResponse<IEnumerable<GetAllTaskResponse>>> GetAll()
    {
        // var response = await _httpClient.GetAsync(TaskRoutes.GetAll);
        // return await ServiceResponse<GetAllTaskResponse>.FromHttpMessage(response);

        return new ServiceResponse<IEnumerable<GetAllTaskResponse>>(true, new[]
        {
            new GetAllTaskResponse
            {
                Id = Guid.NewGuid(),
                Title = "Título",
                Deadline = DateTime.Now,
                Description = "Description",
                Status = ETaskStatus.ToDo
            },
            new GetAllTaskResponse
            {
                Id = Guid.NewGuid(),
                Title = "Título 2",
                Deadline = DateTime.Now,
                Description = "Description",
                Status = ETaskStatus.ToDo
            },
            new GetAllTaskResponse
            {
                Id = Guid.NewGuid(),
                Title = "Título 3",
                Deadline = DateTime.Now,
                Description = "Description",
                Status = ETaskStatus.ToDo
            },
            new GetAllTaskResponse
            {
                Id = Guid.NewGuid(),
                Title = "Título 4",
                Deadline = DateTime.Now,
                Description = "Description",
                Status = ETaskStatus.ToDo
            }
        });
    }
}