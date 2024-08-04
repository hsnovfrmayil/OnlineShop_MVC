using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class User: Entity
{
	public string? UserName { get; set; }

	public string? Email { get; set; }

	public string? PasswordHash { get; set; }

	//Navigation Property

	public ICollection<Review> Reviews { get; set; }
}

