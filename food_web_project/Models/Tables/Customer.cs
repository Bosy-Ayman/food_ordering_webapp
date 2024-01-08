using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace food_web_project.Models.Tables
{
    public class Customer
    {
        [BindProperty]
        public int CustomerId { get; set; }
        [BindProperty]
        [Required]
        public String Email { get; set; }
        [BindProperty]
        [Required]
        public String Password { get; set; }
        [BindProperty]
        public String PhoneNumber { get; set; }
        [BindProperty]
        public String CustomerName { get; set; }
        [BindProperty]
        [Required]
        public string Address { get; set;}
    }
}
