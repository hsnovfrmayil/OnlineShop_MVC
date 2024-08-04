using System;
using OnlineShop_DataAccess.Contexts;
using OnlineShop_DataAccess.Repositories.Abstracts;
using OnlineShop_Domain.Entities.Concretes;

namespace OnlineShop_DataAccess.Repositories.Concretes;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ShopDbContext context) : base(context)
    {
    }
}

