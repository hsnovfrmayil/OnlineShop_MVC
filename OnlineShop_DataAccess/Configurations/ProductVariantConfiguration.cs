using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop_Domain.Entities.Concretes;

namespace OnlineShop_DataAccess.Repositories;

public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
{
    public void Configure(EntityTypeBuilder<ProductVariant> builder)
    {
        // Primary Key
        builder.HasKey(pv => pv.Id);

        // Properties
        builder.Property(pv => pv.Size)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(pv => pv.Color)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(pv => pv.Quantity)
            .IsRequired();

        // Relationships
        builder.HasOne(pv => pv.Product)
            .WithMany(p => p.ProductVariants)
            .HasForeignKey(pv => pv.ProductId);
    }
}

