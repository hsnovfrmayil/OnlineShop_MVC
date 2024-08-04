using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_DataAccess.Repositories.Abstracts;

public interface IGenericRepository<T> where T : Entity, new()
{
    Task<List<T>> GetAllAsync();

    Task<T> GetByIdAsync(int id);

    Task AddAsync(T entity);

    Task Update(T entity);

    Task DeleteAsync(int id);

    Task SaveChanges();
}

