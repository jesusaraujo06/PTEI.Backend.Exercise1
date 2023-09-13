namespace ProductManagement.Shared;

public static class RepositoryReturn
{
    public static ApiResponse<T> Success<T>(T data) => new()
    {
        Success = true,
        Data = data,
        IsException = false
    };

    public static ApiResponse<T> Error<T>(string message) => new()
    {
        Success = false,
        Message = message,
        IsException = false
    };

    public static ApiResponse<T> Exception<T>(string message) => new()
    {
        Success = false,
        Message = message,
        IsException = true
    };
}
