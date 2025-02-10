using NowBuilding.Iservices;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NowBuilding.Model;

namespace NowBuilding.Services 
{
    public class OrderRepository :IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) {
        
            _context = context;
        }
        public IEnumerable<Order> GetOrders()
        {
          return  _context.Orders.Include(o => o.Customer).Include(o => o.Product).ToList();
            //var orders = OrderRepository.

            
        }
        public Order GetOrderByID(int OrderID)
        {

            return _context.Orders.FirstOrDefault(o => o.Id == OrderID);
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
