using FinanceDashboardBackend.Models.Enums;
using System.Collections.Generic;

namespace FinanceDashboardBackend.Models
{
    public class Debt
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DebtStatus Status { get; set; }
        public List<Payment> Payments { get; set; }
        public Person OwedTo { get; set; }
        public Person OwedFrom { get; set; }

        public Debt()
        {
            Payments = new List<Payment>();
        }
    }
}