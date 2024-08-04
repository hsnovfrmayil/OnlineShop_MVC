using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_MVC.ViewComponents;

public class ItemOnlyNameViewComponent: ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}

