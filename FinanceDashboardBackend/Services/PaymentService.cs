using FinanceDashboardBackend.Models;
using System;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Services
{
    public class PaymentService : IService<Payment>
    {
        /// <summary>
        /// Create a new Payment.
        /// </summary>
        /// <param name="payment">The Payment object to be created.</param>
        /// <returns>The newly created Payment object.</returns>
        public Payment Create(Payment payment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a specific Payment.
        /// </summary>
        /// <param name="id">The ID of the Payment to be deleted.</param>
        /// <returns>A boolean indicating whether the deletion was succesful.</returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Edit an existing Payment.
        /// </summary>
        /// <param name="payment">The updated Payment object.</param>
        /// <returns>The updated Payment object.</returns>
        public Payment Edit(Payment payment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch all Payments.
        /// </summary>
        /// <returns>A list of Payment objects.</returns>
        public List<Payment> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch a single Payment.
        /// </summary>
        /// <param name="id">The ID of the requested Payment.</param>
        /// <returns>A Payment object.</returns>
        public Payment GetOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}