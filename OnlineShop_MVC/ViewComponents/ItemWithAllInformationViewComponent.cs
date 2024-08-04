using System;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_MVC.ViewComponents;

public class ItemWithAllInformationViewComponent:ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}

