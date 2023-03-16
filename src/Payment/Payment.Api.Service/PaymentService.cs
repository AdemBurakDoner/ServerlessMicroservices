using Payment.Api.Infrastructure;
using Payment.Api.Models;

namespace Payment.Api.Service
{
    public class PaymentService : IPaymentService
    {
        public PaymentDTO GetById(int id)
        {
            return new PaymentDTO()
            {
                Id = id,
                OrderId = new Random().Next(1, 100),
                Amount = new Random().Next(1, 1000),
                Date = DateTime.Now
            };
        }
    }
}
