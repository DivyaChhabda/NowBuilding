using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using NowBuilding.Iservices;
using NowBuilding.Model;
using NowBuilding.Services;

namespace NowBuildingTestProject
{
    public class OrderRepositoryTests
    {
        private readonly Mock<DbSet<Order>> _mockSet;
        private readonly Mock<ApplicationDbContext> _mockContext;
        private readonly IOrderRepository _repository;

        public OrderRepositoryTests()
        {

            _mockSet=new Mock<DbSet<Order>>();

            _mockContext = new Mock<ApplicationDbContext>();
            _mockContext.Setup(m => m.Orders).Returns(_mockSet.Object);

            _repository=new OrderRepository(_mockContext.Object);
        }
        [Fact]
        public void GetAllOrders()
        {
            var orders = new List<Order>
            {
            new Order { Id = 1, Name="SKU1",CustomerID=1,ProductID=1,Quantity=1 },
            new Order { Id = 2, Name="SKU2",CustomerID=2,ProductID=2,Quantity=2 }
            }.AsQueryable();

            var result =_repository.GetOrders();
            Assert.NotNull(result);
            
            
        }
    }
}
