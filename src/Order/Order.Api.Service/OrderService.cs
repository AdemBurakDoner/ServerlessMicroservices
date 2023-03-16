using Order.Api.Infrastructure;
using Order.Api.Models;

namespace Order.Api.Service
{
    public class OrderService : IOrderService
    {
        public OrderDTO GetById(int id)
        {
            return new OrderDTO()
            {
                Id = id,
                Amount = new Random().Next(1, 1000),
                Date = DateTime.Now
            };
        }
    }
}
