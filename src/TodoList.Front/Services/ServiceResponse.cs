namespace TodoList.Front.Services;

public class ServiceResponse<T> where T : class
{
    public bool Success { get; set; }
    public T? Data { get; set; }

    public ServiceResponse(bool success, T? data)
    {
        Success = success;
        Data = data;
    }

    public static async Task<ServiceResponse<T>> FromHttpMessage(HttpResponseMessage? message)
    {
        if (message is null)
            return new ServiceResponse<T>(false, null);

        T? data = null;
        if (message.IsSuccessStatusCode)
        {
            data = await message.Content.ReadFromJsonAsync<T>();
        }

        return new ServiceResponse<T>(message.IsSuccessStatusCode, data);
    }
}