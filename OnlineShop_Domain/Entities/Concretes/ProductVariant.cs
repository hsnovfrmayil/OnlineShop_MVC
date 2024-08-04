using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class ProductVariant : Entity
{
    public int ProductId { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public int Quantity { get; set; }

    //Navigation Property

    public Product Product { get; set; }
}

