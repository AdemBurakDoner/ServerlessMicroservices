using Microsoft.AspNetCore.Mvc;
using Order.Api.Infrastructure;
using Order.Api.Models;

namespace Order.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public OrderDTO GetById(int id)
        {
            return _orderService.GetById(id);
        }
    }
}
