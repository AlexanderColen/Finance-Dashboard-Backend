using FinanceDashboardBackend.Models;
using FinanceDashboardBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly PersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _personService.Delete(id);
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personService.GetAll();
        }

        [HttpGet]
        public Person Get(int id)
        {
            return _personService.GetOne(id);
        }

        [HttpPost]
        public Person Post(Person person)
        {
            return _personService.Create(person);
        }

        [HttpPut]
        public Person Put(Person person)
        {
            return _personService.Edit(person);
        }
    }
}
