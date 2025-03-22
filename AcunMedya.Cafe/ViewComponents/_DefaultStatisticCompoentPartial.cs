using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace AcunMedya.Cafe.ViewComponents
{
	public class _DefaultStatisticCompoentPartial:ViewComponent
	{
		private readonly CafeContext _context;

		public _DefaultStatisticCompoentPartial(CafeContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			ViewBag.ProductCount = _context.Products.Count();
			ViewBag.CategoryCount = _context.Categories.Count();
			ViewBag.TestimonialCount = _context.Testimonials.Count();
			//ViewBag.FeatureCount = _context.Features.Count();
			return View();
		}
	}
}
