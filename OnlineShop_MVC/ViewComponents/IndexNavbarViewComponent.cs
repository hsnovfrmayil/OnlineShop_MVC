using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_MVC.ViewComponents;

public class IndexNavbarViewComponent :ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}

