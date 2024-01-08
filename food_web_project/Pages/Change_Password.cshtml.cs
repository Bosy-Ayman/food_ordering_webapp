using food_web_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class Change_PasswordModel : PageModel
    {
        private readonly ILogger<Change_PasswordModel> _logger;
        private readonly DB dB;
        public Change_PasswordModel(ILogger<Change_PasswordModel> logger, DB db)
        {
            _logger = logger;
            dB = db;

        }
        public void OnGet()
        {
        }
    }
}
