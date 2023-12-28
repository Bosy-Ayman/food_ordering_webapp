namespace food_web_project.Models.Tables
{
    public class Payment
    {
        public int Amount { get; set; }
        public int Code { get; set; }
        public Promotion CouponID { get; set; }
        public int Type { get; set; }
        public Users CustomerID { get; set; }
        //foreign key??
    }
}
