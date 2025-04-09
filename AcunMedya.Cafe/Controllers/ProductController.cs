using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AcunMedya.Cafe.Controllers
{
    public class ProductController : Controller
    {
        private readonly CafeContext _context;

        public ProductController(CafeContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //Eager Loading
            var values=_context.Products.Include(x=>x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {

            List<SelectListItem> values = (from x in _context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }
                                         ).ToList();
            ViewBag.v = values;
            return View();
        }
    }
}
