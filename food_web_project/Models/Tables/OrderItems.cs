namespace food_web_project.Models.Tables
{
    public class OrderItems
    {
        public int ImageUrl { get; set; }
        public int OrderItemID { get; set; }
        public Cart CartID { get; set; }
        public Users UsersID { get; set;}
    }
}
