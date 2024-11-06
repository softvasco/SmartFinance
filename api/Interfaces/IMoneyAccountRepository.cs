using shared.DTOs.MoneyAccounts;

namespace api.Interfaces
{
    public interface IMoneyAccountRepository
    {
        Task<List<MoneyAccountDto>> GetAsync();
    }
}
