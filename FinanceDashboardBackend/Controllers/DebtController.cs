using FinanceDashboardBackend.Models;
using FinanceDashboardBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DebtController : ControllerBase
    {
        private readonly DebtService _debtService;

        public DebtController(FinancialContext financialContext)
        {
            _debtService = new DebtService(financialContext);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _debtService.Delete(id);
        }

        [HttpGet]
        public IEnumerable<Debt> Get()
        {
            return _debtService.GetAll();
        }

        [HttpGet]
        public Debt Get(int id)
        {
            return _debtService.GetOne(id);
        }

        [HttpPost]
        public Debt Post(Debt debt)
        {
            return _debtService.Create(debt);
        }

        [HttpPut]
        public Debt Put(Debt debt)
        {
            return _debtService.Edit(debt);
        }
    }
}