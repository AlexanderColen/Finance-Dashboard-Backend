using FinanceDashboardBackend.Models;
using FinanceDashboardBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService _paymentService;

        public PaymentController(FinancialContext financialContext)
        {
            _paymentService = new PaymentService(financialContext);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _paymentService.Delete(id);
        }

        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            return _paymentService.GetAll();
        }

        [HttpGet]
        public Payment Get(int id)
        {
            return _paymentService.GetOne(id);
        }

        [HttpPost]
        public Payment Post(Payment payment)
        {
            return _paymentService.Create(payment);
        }

        [HttpPut]
        public Payment Put(Payment payment)
        {
            return _paymentService.Edit(payment);
        }
    }
}