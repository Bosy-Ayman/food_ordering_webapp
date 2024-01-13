using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using food_web_project.Models;
using food_web_project.Models.Tables;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace food_web_project.Pages
{
    public class Sign_InModel : PageModel
    {
        private readonly ILogger<Sign_InModel> _logger;
        private readonly DB dB;

        [BindProperty]
        public int? user_Type { get; set; }

        [BindProperty]
        public int user_ID { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string user_email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter your password.")]
        public string user_password { get; set; }

        public Sign_InModel(ILogger<Sign_InModel> logger, DB db)
        {
            _logger = logger;
            dB = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                user_ID = dB.GetUserID(user_email);

                if (user_ID > 0)
                {
                    string password = dB.GetPassword(user_ID).Trim();
                    user_password = user_password.Trim();

                    if (user_password == password)
                    {
                        dB.Login(user_ID);

                        user_Type = dB.GetUserType(user_ID);

                        if (user_Type == 1)
                            return RedirectToPage("/Dashboard", new { ID = user_ID });
                        else if (user_Type == 2)
                            return RedirectToPage("/User_Profile", new { ID = user_ID });
                    }
                }

                // Handle the case when no user is found or the password is incorrect
                ViewData["ErrorMessage"] = "Invalid email or password.";
                return Page();
            }

            // Model validation failed
            return Page();
        }
    }
}

