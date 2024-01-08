
using food_web_project.Models;
using food_web_project.Models.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data;

using System.Runtime.Intrinsics.X86;

namespace food_web_project.Pages
{
    public class SignUpModel : PageModel
    {
        public readonly DB Db;
        [Required]
        [StringLength(40)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        public string CustomerName { get; set; }
        public SignUpModel(DB db)
        {
            Db = db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPostSubmit()
        {
            if (ModelState.IsValid)
            {
                Db.AddUser(CustomerName, Email, PhoneNumber, Password);
                return RedirectToPage("/User_Profile");
            }
           
                return Page();
           
        }


    }
}

