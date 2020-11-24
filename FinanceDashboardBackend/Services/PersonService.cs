using FinanceDashboardBackend.Models;
using System;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Services
{
    public class PersonService : IService<Person>
    {
        /// <summary>
        /// Create a new Person.
        /// </summary>
        /// <param name="person">The Person object to be created.</param>
        /// <returns>The newly created Person object.</returns>
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a specific Person.
        /// </summary>
        /// <param name="id">The ID of the Person to be deleted.</param>
        /// <returns>A boolean indicating whether the deletion was succesful.</returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Edit an existing Person.
        /// </summary>
        /// <param name="person">The updated Person object.</param>
        /// <returns>The updated Person object.</returns>
        public Person Edit(Person person)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch all Persons.
        /// </summary>
        /// <returns>A list of Person objects.</returns>
        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch a single Person.
        /// </summary>
        /// <param name="id">The ID of the requested Person.</param>
        /// <returns>A Person object.</returns>
        public Person GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}