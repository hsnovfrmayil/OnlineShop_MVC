using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class GenderCategory :Entity
{
    public string? GenderCategoryName { get; set; }

    //Navigation Property

    public ICollection <Product> Products { get; set; }
}

