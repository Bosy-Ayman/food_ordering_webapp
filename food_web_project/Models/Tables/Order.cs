namespace food_web_project.Models.Tables
{
    public class Order
    {
        public int OrderID { get; set; }
        public Users CustomerID { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }
        /* public DateTime OrderDateTime { get; set; }*/
        public string OrderDateTime { get; set; }
    }
}
