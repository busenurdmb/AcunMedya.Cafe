using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.ViewComponents
{
	public class _DefaultHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}


//Views Shared Components ismini Default