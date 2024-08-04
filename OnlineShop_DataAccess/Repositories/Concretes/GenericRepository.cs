using System;
using Microsoft.EntityFrameworkCore;
using OnlineShop_DataAccess.Contexts;
using OnlineShop_DataAccess.Repositories.Abstracts;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_DataAccess.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : Entity, new()
{
    protected readonly ShopDbContext _context;

    public GenericRepository(ShopDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(u => u.Id == id);
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}

