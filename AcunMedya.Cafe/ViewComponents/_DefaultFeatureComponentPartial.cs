
using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.ViewComponents
{
	public class _DefaultFeatureComponentPartial:ViewComponent
	{
		//CafeContext Db=new CafeContext();

		private readonly CafeContext _context;

		//constructor
        public _DefaultFeatureComponentPartial(CafeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			//var value=_context.Features.ToList();
			ViewBag.Subtitle=_context.Features.Select(x=>x.SubTitle).FirstOrDefault();
			ViewBag.Title= _context.Features.Select(x=>x.Title).FirstOrDefault();
			return View();
		}
	}
}










//Views->Shared->Components->_DefaultFeatureComponentPartial->Defaut.cshtml
