namespace ProductManagement.Domain.Repository;

public interface IGenericRepository<T> where T : class
{
    public Task<T> GetById(int id);
    public Task<List<T>> GetAll();
    public Task Add(T entity);
    public Task AddRange(List<T> entities);
    public Task Update(T entity);
    public Task UpdateRange(List<T> entities);
    public Task Remove(int id);
}
