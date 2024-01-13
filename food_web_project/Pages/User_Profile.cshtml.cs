using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{

    public class User_ProfileModel : PageModel
    {
        private readonly ILogger<User_ProfileModel> _logger;
        private readonly DB dB;
        public User_ProfileModel(ILogger<User_ProfileModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
