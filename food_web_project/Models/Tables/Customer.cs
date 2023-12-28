namespace food_web_project.Models.Tables
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public char Email { get; set; }
        public char Password { get; set; }
        public int PhoneNumber { get; set; }
        public char CustomerName { get; set; }
        public string Address { get; set;}
        //foreign key??
    }
}
