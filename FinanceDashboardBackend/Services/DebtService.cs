using FinanceDashboardBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceDashboardBackend.Services
{
    public class DebtService : IService<Debt>
    {
        private readonly FinancialContext _dataContext;

        public DebtService(FinancialContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Create a new Debt.
        /// </summary>
        /// <param name="debt">The Debt object to be created.</param>
        /// <returns>The newly created Debt object.</returns>
        public Debt Create(Debt debt)
        {
            try
            {
                _dataContext.Debts.Add(debt);
                _dataContext.SaveChangesAsync();
            } catch (DbUpdateException)
            {
                return null;
            }
            
            return debt;
        }

        /// <summary>
        /// Delete a specific Debt.
        /// </summary>
        /// <param name="id">The ID of the Debt to be deleted.</param>
        /// <returns>A boolean indicating whether the deletion was succesful.</returns>
        public bool Delete(int id)
        {
            try
            {
                var debt = _dataContext.Debts.Where(d => d.Id == id).FirstOrDefault();
                _dataContext.Debts.Remove(debt);
                _dataContext.SaveChangesAsync();
                return true;
            } catch (DbUpdateException)
            {
                return false;
            }
        }

        /// <summary>
        /// Edit an existing Debt.
        /// </summary>
        /// <param name="debt">The updated Debt object.</param>
        /// <returns>The updated Debt object.</returns>
        public Debt Edit(Debt debt)
        {
            try
            {
                var d = _dataContext.Debts.Where(d => d.Id == debt.Id).FirstOrDefault();
                d.Amount = debt.Amount;
                d.Description = debt.Description;
                d.Payments = debt.Payments;
                d.Status = debt.Status;
                _dataContext.SaveChangesAsync();
                return d;
            } catch (DbUpdateException)
            {
                return null;
            }
        }

        /// <summary>
        /// Fetch all Debts.
        /// </summary>
        /// <returns>A list of Debt objects.</returns>
        public List<Debt> GetAll()
        {
            return _dataContext.Debts.ToList();
        }

        /// <summary>
        /// Fetch a single Debt.
        /// </summary>
        /// <param name="id">The ID of the requested Debt.</param>
        /// <returns>A Debt object.</returns>
        public Debt GetOne(int id)
        {
            return _dataContext.Debts.Where(d => d.Id == id).FirstOrDefault();
        }
    }
}