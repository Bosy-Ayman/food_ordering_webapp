using food_web_project.Models.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food_web_project.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public Customer customer { get; set; }


        public void OnGet()
        {

        }
       
    }

}
