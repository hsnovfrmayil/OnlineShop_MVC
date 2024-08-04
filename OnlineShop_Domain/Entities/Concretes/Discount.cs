using System;
using OnlineShop_Domain.Entities.Abstracts;

namespace OnlineShop_Domain.Entities.Concretes;

public class Discount : Entity
{
    public int ProductId { get; set; }

    public int DiscountPercentage { get; set; }

    public DateTime DiscountStartDate { get; set; }

    public DateTime DiscountEndDate { get; set; }

    //Navigaion Property

    public Product Product { get; set; }
}

