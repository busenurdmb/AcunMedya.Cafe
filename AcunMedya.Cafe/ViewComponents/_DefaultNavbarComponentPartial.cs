using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.ViewComponents
{
	public class _DefaultNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
