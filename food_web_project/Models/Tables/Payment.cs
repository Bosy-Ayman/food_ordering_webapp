namespace food_web_project.Models.Tables
{
    public class Payment
    {
        public int Amount { get; set; }
        public int Code { get; set; }
        public string CouponID { get; set; }
        public int Type { get; set; }
        public string CustomerID { get; set; }
        //foreign key??
    }
}
