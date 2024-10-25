using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextoptions)
        : base(dbContextoptions)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<MoneyAccount> MoneyAccounts { get; set; }
        public DbSet<FinanceGoal> FinanceGoals { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}