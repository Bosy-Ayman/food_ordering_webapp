using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class Forgot_PasswordModel : PageModel
    {

        private readonly ILogger<Forgot_PasswordModel> _logger;
        private readonly DB dB;
        public Forgot_PasswordModel(ILogger<Forgot_PasswordModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
