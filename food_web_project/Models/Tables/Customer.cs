using System.ComponentModel.DataAnnotations;

namespace food_web_project.Models.Tables
{
    public class Customer
    {
        public Users CustomerId { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String PhoneNumber { get; set; }
        public String CustomerName { get; set; }
        public string Address { get; set;}
    }
}
