namespace api.Models
{
    public class User : BaseEntity
    {
        public required string Name { get; set; } 
        public required string Username { get; set; } 
        public required string Email { get; set; }

        public ICollection<FinanceGoal> FinanceGoals { get; set; } = [];
        public ICollection<MoneyAccount> MoneyAccounts { get; set; } = [];
    }
}
