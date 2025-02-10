namespace NowBuilding.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get;set; }

        public int Quantity { get;set; }

        public  Customer Customer { get; set; }
        public  Product Product { get; set; }
    }
}
