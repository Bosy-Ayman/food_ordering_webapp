using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace food_web_project.Models.Tables
{
    public class Customer
    {
        [Required]
        [BindProperty]

        public int CustomerId { get; set; }
        [Required]
        [BindProperty]

        public String Email { get; set; }
        [Required]
        [BindProperty]

        public String Password { get; set; }
        [Required]
        [BindProperty]
        public String PhoneNumber { get; set; }
        [Required]
        public String CustomerName { get; set; }
        [Required]
        [BindProperty]
        public string Address { get; set;}
    }
}
