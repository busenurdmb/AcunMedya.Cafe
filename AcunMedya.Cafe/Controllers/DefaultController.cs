using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
