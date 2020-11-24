using FinanceDashboardBackend.Models;
using System;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Services
{
    public class DebtService : IService<Debt>
    {
        /// <summary>
        /// Create a new Debt.
        /// </summary>
        /// <param name="debt">The Debt object to be created.</param>
        /// <returns>The newly created Debt object.</returns>
        public Debt Create(Debt debt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a specific Debt.
        /// </summary>
        /// <param name="id">The ID of the Debt to be deleted.</param>
        /// <returns>A boolean indicating whether the deletion was succesful.</returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Edit an existing Debt.
        /// </summary>
        /// <param name="debt">The updated Debt object.</param>
        /// <returns>The updated Debt object.</returns>
        public Debt Edit(Debt debt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch all Debts.
        /// </summary>
        /// <returns>A list of Debt objects.</returns>
        public List<Debt> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch a single Debt.
        /// </summary>
        /// <param name="id">The ID of the requested Debt.</param>
        /// <returns>A Debt object.</returns>
        public Debt GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}