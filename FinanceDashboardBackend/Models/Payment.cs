using System;

namespace FinanceDashboardBackend.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Debt Debt { get; set; }
    }
}