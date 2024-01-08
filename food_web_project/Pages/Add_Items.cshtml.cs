using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class Add_ItemsModel : PageModel
    {
        private readonly ILogger<Add_ItemsModel> _logger;
        private readonly DB dB;
        public Add_ItemsModel(ILogger<Add_ItemsModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
