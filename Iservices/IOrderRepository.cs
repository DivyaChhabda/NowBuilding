using NowBuilding.Model;

namespace NowBuilding.Iservices
{
    public interface IOrderRepository 
    {
       
        public IEnumerable<Order> GetOrders();
        public Order GetOrderByID(int id);
        public void CreateOrder(Order order);

    }
}
