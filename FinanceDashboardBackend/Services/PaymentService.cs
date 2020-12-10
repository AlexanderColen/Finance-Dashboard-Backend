using FinanceDashboardBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceDashboardBackend.Services
{
    public class PaymentService : IService<Payment>
    {
        private readonly FinancialContext _dataContext;

        public PaymentService(FinancialContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Create a new Payment.
        /// </summary>
        /// <param name="payment">The Payment object to be created.</param>
        /// <returns>The newly created Payment object.</returns>
        public Payment Create(Payment payment)
        {
            try
            {
                _dataContext.Payments.Add(payment);
                _dataContext.SaveChangesAsync();
            } catch (DbUpdateException)
            {
                return null;
            }
            
            return payment;
        }

        /// <summary>
        /// Delete a specific Payment.
        /// </summary>
        /// <param name="id">The ID of the Payment to be deleted.</param>
        /// <returns>A boolean indicating whether the deletion was succesful.</returns>
        public bool Delete(int id)
        {
            try
            {
                var payment = _dataContext.Payments.Where(p => p.Id == id).FirstOrDefault();
                _dataContext.Payments.Remove(payment);
                _dataContext.SaveChangesAsync();
                return true;
            } catch (DbUpdateException)
            {
                return false;
            }
        }

        /// <summary>
        /// Edit an existing Payment.
        /// </summary>
        /// <param name="payment">The updated Payment object.</param>
        /// <returns>The updated Payment object.</returns>
        public Payment Edit(Payment payment)
        {
            try
            {
                var p = _dataContext.Payments.Where(p => p.Id == payment.Id).FirstOrDefault();
                p.Amount = payment.Amount;
                p.Date = payment.Date;
                p.Debt = payment.Debt;
                _dataContext.SaveChangesAsync();
                return p;
            } catch (DbUpdateException)
            {
                return null;
            }
        }

        /// <summary>
        /// Fetch all Payments.
        /// </summary>
        /// <returns>A list of Payment objects.</returns>
        public List<Payment> GetAll()
        {
            return _dataContext.Payments.ToList();
        }

        /// <summary>
        /// Fetch a single Payment.
        /// </summary>
        /// <param name="id">The ID of the requested Payment.</param>
        /// <returns>A Payment object.</returns>
        public Payment GetOne(int id)
        {
            return _dataContext.Payments.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}