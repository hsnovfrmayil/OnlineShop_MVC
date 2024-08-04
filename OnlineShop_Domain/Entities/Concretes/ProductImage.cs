using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class ProductImage :Entity
{
    public int ProductId { get; set; }

    public string? ImageUrl { get; set; }

    public bool IsPrimary { get; set; }

    //Navigation Property

    public Product Product { get; set; }
}

