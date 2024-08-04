using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_MVC.ViewComponents;

public class DetailNavbarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

