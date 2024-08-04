using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop_Domain.Entities.Concretes;

namespace OnlineShop_DataAccess.Repositories;

public class GenderCategoryConfiguration : IEntityTypeConfiguration<GenderCategory>
{
    public void Configure(EntityTypeBuilder<GenderCategory> builder)
    {
        // Primary Key
        builder.HasKey(gc => gc.Id);

        // Properties
        builder.Property(gc => gc.GenderCategoryName)
            .IsRequired()
            .HasMaxLength(255);

        // Relationships
       
    }
}

