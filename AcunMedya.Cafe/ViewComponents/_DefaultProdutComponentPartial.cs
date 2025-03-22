using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Cafe.ViewComponents
{
	public class _DefaultProdutComponentPartial:ViewComponent
	{
		//CafeContext Db=new CafeContext();

		private readonly CafeContext _context;
		
		public _DefaultProdutComponentPartial(CafeContext context)
		{
			_context = context;
		}

		//constructor

		public IViewComponentResult Invoke()
		{
			//Eager Loading 
			var values=_context.Products.Include(x=>x.Category).ToList();
			return View(values);
		}
	}
}
