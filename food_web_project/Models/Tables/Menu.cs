namespace food_web_project.Models.Tables
{
    public class Menu
    {
        public int MenuName { get; set; }
        public int Price { get; set; }
        public char Category { get; set; }
        public int AdminID { get; set; }
        //foreign key??
    }
}
