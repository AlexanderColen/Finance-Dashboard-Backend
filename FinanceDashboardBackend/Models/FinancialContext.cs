using Microsoft.EntityFrameworkCore;

namespace FinanceDashboardBackend.Models
{
    public class FinancialContext : DbContext
    {
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public FinancialContext(DbContextOptions<FinancialContext> options) : base(options) { }
    }
}