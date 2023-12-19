using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]

        public string Username { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;
        [BindProperty]
        public string Phone_Number { get; set; } = string.Empty;
        [BindProperty]
        public string Email { get; set; } = string.Empty;
        public void OnGet()
        {
        }
       
    }

}
