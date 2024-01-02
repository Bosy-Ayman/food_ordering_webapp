using food_web_project.Models.Tables;

namespace food_web_project.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public OrderItems OrderItemID{ get; set; }
        public int TotalPrice { get; set; }
        public int ItemAmount { get; set; }
    }
}
