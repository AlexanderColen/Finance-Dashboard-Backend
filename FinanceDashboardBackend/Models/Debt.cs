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
        public ICollection<Payment> Payments { get; set; }
    }
}