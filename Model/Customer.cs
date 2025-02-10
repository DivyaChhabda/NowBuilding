namespace NowBuilding.Model
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }

        public ICollection<Order> Orders { get; set; }=new List<Order>();
    }
}
