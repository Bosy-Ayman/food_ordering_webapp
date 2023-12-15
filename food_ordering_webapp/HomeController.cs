using Microsoft.AspNetCore.Mvc;

namespace food_ordering_webapp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
