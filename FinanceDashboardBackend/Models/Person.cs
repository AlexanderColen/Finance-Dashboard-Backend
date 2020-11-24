using System.Collections.Generic;

namespace FinanceDashboardBackend.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Payment> PaymentsTo { get; set; }
        public List<Payment> PaymentsFrom { get; set; }

        public Person()
        {
            Payments = new List<Payment>();
            PaymentsFrom = new List<Payment>();
            PaymentsTo = new List<Payment>();
        }
    }
}