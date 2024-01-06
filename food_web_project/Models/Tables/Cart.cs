using food_web_project.Models.Tables;
using Microsoft.AspNetCore.Mvc;

namespace food_web_project.Models
{
    public class Cart
    {
        [BindProperty]
        public Users CartID { get; set; }
        [BindProperty]
        public OrderItems OrderItemID{ get; set; }
        [BindProperty]

        public int TotalPrice { get; set; }
        [BindProperty]
        public int ItemAmount { get; set; }
    }
}
