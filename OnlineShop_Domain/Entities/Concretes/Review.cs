using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class Review :Entity
{
	public int ProductId { get; set; }

	public int UserId { get; set; }

	public string? ReviewText { get; set; }

	public int Rating { get; set; }

	//Navigation Property

	public User User { get; set; }

	public Product Product { get; set; }

}

