using System;

namespace FinanceDashboardBackend.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Person Payee { get; set; }
        public Payment Payment { get; set; }
    }
}