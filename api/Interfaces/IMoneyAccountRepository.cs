using api.Models;
using Shared.DTOs.MoneyAccounts;

namespace api.Interfaces
{
    public interface IMoneyAccountRepository
    {
        Task<List<MoneyAccountDto>> GetAsync();
    }
}
