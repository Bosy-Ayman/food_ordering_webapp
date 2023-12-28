namespace food_web_project.Models.Tables
{
    public class Administrator
    {
        public int AdminId { get; set; }
        public char AdminName { get; set; }
        public char Email { get; set; }
        public int PhoneNumber { get; set; }
        public char Password { get; set; }
        public int UserID { get; set; }
        //foreign key??
    }
}
