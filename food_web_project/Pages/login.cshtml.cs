// Login.cshtml.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username == "me@gmail.com" && Password == "2023")//admin
            {
                return RedirectToPage("/User_Profile");
            }
            else if (Username == "user2@gmail.com" && Password == "2023")//user from the database
            {
                return RedirectToPage("/Dashboard");
            }
            else
            {
                ViewData["ErrorMessage"] = "Invalid username or password";
                return Page();
            }
        }
    }
}
