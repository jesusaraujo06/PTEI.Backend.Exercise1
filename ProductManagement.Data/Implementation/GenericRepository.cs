using Microsoft.EntityFrameworkCore;
using ProductManagement.Data.Context;
using ProductManagement.Domain.Repository;

namespace ProductManagement.Data.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public ProductManagementDbContext Context { get; }

    public GenericRepository(ProductManagementDbContext context)
    {
        Context = context;
    }

    public async Task Add(T entity)
    {
        await Context.Set<T>().AddAsync(entity);
        await Context.SaveChangesAsync();
    }

    public async Task AddRange(List<T> entities)
    {
        await Context.Set<T>().AddRangeAsync(entities);
        await Context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAll()
    {
        var records = await Context.Set<T>().ToListAsync();
        return records;
    }

    public async Task<T> GetById(int id)
    {
        var record = await Context.Set<T>().FindAsync(id);
        return record;
    }

    public async Task Remove(int id)
    {
        var record = await Context.Set<T>().FindAsync(id);
        if (record != null)
        {
            Context.Set<T>().Remove(record);
            await Context.SaveChangesAsync();
        }
    }

    public async Task Update(T entity)
    {
        Context.Update(entity);
        await Context.SaveChangesAsync();
    }

    public async Task UpdateRange(List<T> entities)
    {
        // Marcar todas las entidades como modificadas en el contexto
        foreach (var entity in entities)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        Context.Set<T>().UpdateRange(entities);
        await Context.SaveChangesAsync();
    }
}
