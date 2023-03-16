using Microsoft.AspNetCore.Mvc;
using Payment.Api.Infrastructure;
using Payment.Api.Models;

namespace Payment.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("{id}")]
        public PaymentDTO GetById(int id)
        {
            return _paymentService.GetById(id);
        }
    }
}
