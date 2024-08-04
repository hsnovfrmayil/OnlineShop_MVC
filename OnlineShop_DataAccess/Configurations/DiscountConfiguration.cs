using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop_Domain.Entities.Concretes;

namespace OnlineShop_DataAccess.Repositories;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        // Primary Key
        builder.HasKey(d => d.Id);

        // Properties
        builder.Property(d => d.DiscountPercentage)
            .IsRequired();

        builder.Property(d => d.DiscountStartDate)
            .IsRequired();

        builder.Property(d => d.DiscountEndDate)
            .IsRequired();

        // Relationships
        builder.HasOne(d => d.Product)
            .WithMany(p => p.Discounts)
            .HasForeignKey(d => d.ProductId);
    }
}

