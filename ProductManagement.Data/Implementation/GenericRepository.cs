using Microsoft.EntityFrameworkCore;
using ProductManagement.Data.Context;
using ProductManagement.Domain.Repository;
using ProductManagement.Shared;

namespace ProductManagement.Data.Implementation;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public ProductManagementDbContext Context { get; }

    public GenericRepository(ProductManagementDbContext context)
    {
        Context = context;
    }

    public async Task<ApiResponse<bool>> Add(T entity)
    {
        try
        {
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return RepositoryReturn.Success(true);
            
        }
        catch (Exception ex)
        {

            return RepositoryReturn.Exception<bool>(ex.Message);
        }
    }

    public async Task<ApiResponse<bool>> AddRange(List<T> entities)
    {
        try
        {
            await Context.Set<T>().AddRangeAsync(entities);
            await Context.SaveChangesAsync();
            return RepositoryReturn.Success(true);
        }
        catch (Exception ex)
        {
            return RepositoryReturn.Exception<bool>(ex.Message);
        }  
    }

    public async Task<ApiResponse<List<T>>> GetAll()
    {
        try
        {
            var records = await Context.Set<T>().ToListAsync();
            return RepositoryReturn.Success(records);
        }
        catch (Exception ex)
        {
            return RepositoryReturn.Exception<List<T>>(ex.Message);
        }
   
    }

    public async Task<ApiResponse<T>> GetById(int id)
    {
        try
        {
            var record = await Context.Set<T>().FindAsync(id);
            return RepositoryReturn.Success(record);
        }
        catch (Exception ex)
        {
            return RepositoryReturn.Exception<T>(ex.Message);
        }
    }

    public async Task<ApiResponse<bool>> Remove(int id)
    {
        try
        {
            var record = await Context.Set<T>().FindAsync(id);
            if (record != null)
            {
                Context.Set<T>().Remove(record);
                await Context.SaveChangesAsync();
                return RepositoryReturn.Success(true);
            }
            else
            {
                return RepositoryReturn.Error<bool>("No se encontró el producto a eliminar");
            }
        }
        catch (Exception ex)
        {
            return RepositoryReturn.Exception<bool>(ex.Message);
        }
    }

    public async Task<ApiResponse<bool>> Update(T entity)
    {
        try
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return RepositoryReturn.Success(true);
        }
        catch (Exception ex)
        {
            return RepositoryReturn.Exception<bool>(ex.Message);
        }
    }

    public async Task<ApiResponse<bool>> UpdateRange(List<T> entities)
    {
        try
        {
            // Marcar todas las entidades como modificadas en el contexto
            foreach (var entity in entities)
            {
                Context.Entry(entity).State = EntityState.Modified;
            }

            Context.Set<T>().UpdateRange(entities);
            await Context.SaveChangesAsync();
            return RepositoryReturn.Success(true);
        }
        catch (Exception ex)
        {
            return RepositoryReturn.Exception<bool>(ex.Message);
        }
    }
}
