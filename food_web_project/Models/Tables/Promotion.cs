namespace food_web_project.Models.Tables
{
    public class Promotion
    {
        public int CouponID { get; set; }
        public string Code { get; set; }
        public Order OrderID { get; set; }
        public float DiscountPercentage { get; set; }
    }
}
