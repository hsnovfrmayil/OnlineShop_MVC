using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class Category :Entity
{
	public string? CategoryName { get; set; }

    //Navigation Property

    public ICollection<Product> Products { get; set; }
}

