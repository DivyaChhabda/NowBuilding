using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NowBuilding.Iservices;
using NowBuilding.Model;
using NowBuilding.Services;

namespace NowBuilding.Controllers 
{
    public class OrderController :ControllerBase
    {
        private readonly OrderRepository _orderRepository;
      
        public OrderController(OrderRepository orderRepository) {


            _orderRepository = orderRepository;
           
           
        }


        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var orders = _orderRepository.GetOrders();
            //var orders = OrderRepository.

            return Ok(orders);
        }

        public Order GetOrderByID(int orderID) {

            return _orderRepository.GetOrderByID(orderID);
        }

        public void AddOrder(Order order) { 
            
            _orderRepository.CreateOrder(order);
           
        }
    }
}
