using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_MVC.ViewComponents;

public class ShopNavbarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

