using ProductManagement.Shared;

namespace ProductManagement.Domain.Repository;

public interface IGenericRepository<T> where T : class
{
    public Task<ApiResponse<T>> GetById(int id);
    public Task<ApiResponse<List<T>>> GetAll();
    public Task<ApiResponse<bool>> Add(T entity);
    public Task<ApiResponse<bool>> AddRange(List<T> entities);
    public Task<ApiResponse<bool>> Update(T entity);
    public Task<ApiResponse<bool>> UpdateRange(List<T> entities);
    public Task<ApiResponse<bool>> Remove(int id);
}
