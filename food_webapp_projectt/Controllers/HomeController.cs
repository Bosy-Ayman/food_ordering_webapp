using food_webapp_projectt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace food_webapp_projectt.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
       
     
        public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult login()
		{
			return View();
		}
		public IActionResult cart()
		{
			return View();
		}
        public IActionResult dashboard()
        {
            return View();
        }
        public IActionResult user_profile()
        {
            return View();
        }
        public IActionResult payment()
        {
            return View();
        }
        public IActionResult item_single()
        {
            return View();
        }
        public IActionResult items_single()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

    
}

}


namespace food_webapp_projectt.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "poussy.ayman1@gmail.com" && password == "2023")
            {
                // Redirect to dashboard
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                // Redirect to login with an error message
                ViewBag.ErrorMessage = "Invalid username or password.";

                // Add a script to reload the page
                ViewBag.ReloadScript = true;

                return RedirectToAction("Login", "Home");
            }
        }

        public ActionResult Dashboard()
        {
            return View();
        }
       
    }
}
