using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace food_web_project.Models.Tables
{
    public class Administrator
    {

        public int AdminId { get; set; }
        public string AdminName { get; set; }
        [BindProperty]
        [Required]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        [BindProperty]
        [Required]
        public string Password { get; set; }
        [BindProperty]
        public Users UserID { get; set; }
        //foreign key??
    }
}
