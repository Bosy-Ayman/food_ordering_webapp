using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class Sign_UpModel : PageModel
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


/*using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using food_web_project.Models;
using food_web_project.Models.Tables;
namespace food_web_project.Pages
{
    public class Sign_UpModel : PageModel
    {
        [BindProperty]
        public Users Users { get; set; }

        public void OnGet()
        {
        }

       *//* public IActionResult OnPost()
        {
            DB db = new DB();
            Users authenticatedUser = db.AuthenticateUser(Users.Username, Users.Password);

            if (authenticatedUser != null)
            {
                // Redirect to the user's profile page based on their ID
                return RedirectToPage("/UserProfile", new { userId = authenticatedUser.UserId });
            }
            else
            {
                ViewData["ErrorMessage"] = "Invalid username or password";
                return Page();
            }
        }*//*
    }


}
*/