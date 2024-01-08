using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class Product_AdminModel : PageModel
    {
        private readonly ILogger<Product_AdminModel> _logger;
        private readonly DB dB;
        public Product_AdminModel(ILogger<Product_AdminModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
