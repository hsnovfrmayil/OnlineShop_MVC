using System;
using Microsoft.EntityFrameworkCore;
using OnlineShop_Domain.Entities.Concretes;

namespace OnlineShop_DataAccess.Contexts;

public class ShopDbContext :DbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Discount> Discounts { get; set; }

    public DbSet<GenderCategory> GenderCategories { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductImage> ProductImages { get; set; }

    public DbSet<ProductVariant> ProductVariants { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<User> Users { get; set; }

    public ShopDbContext() { }

    public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Məlumat bazası provayderinizi təyin edin
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EShopDB;User ID=SA;Password=reallyStrongPwd123;TrustServerCertificate=True");
            // Yoxsa başqa bir provayder istifadə edə bilərsiniz, məsələn:
            // optionsBuilder.UseSqlite("YourConnectionStringHere");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}

