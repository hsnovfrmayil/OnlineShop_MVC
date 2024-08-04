using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class Product :Entity
{
	public int CategoryId { get; set; }

	public int GenderCategoryId { get; set; }

	public string? ProductName { get; set; }

	public string? Description { get; set; }

	public string? Information { get; set; }

	public long PriceBeforeDiscount { get; set; }

    public long PriceAfterDiscount { get; set; }

    public int StockQuantity { get; set; }

	//Navigation Property

	public Category Category { get; set; }

	public ICollection<GenderCategory> GenderCategories { get; set; }

	public ICollection<ProductVariant> ProductVariants { get; set; }

	public ICollection<Review> Reviews { get; set; }

	public ICollection<Discount> Discounts { get; set; }

	public ICollection<ProductImage> ProductImages { get; set; }
}

