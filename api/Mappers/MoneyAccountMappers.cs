using api.Models;
using Shared.DTOs.MoneyAccounts;

namespace api.Mappers
{
    public static class MoneyAccountMappers
    {
        public static MoneyAccount ToMoneyAccountFromCreateMoneyAccountDto(this CreateMoneyAccountDto createMoneyAccountDto)
        {
            return new MoneyAccount
            {
                //Code = createFinanceGoalDto.Code,
                //SmallDescription = createFinanceGoalDto.SmallDescription,
                //FullDescription = createFinanceGoalDto.FullDescription,
                //CurrentDebtAmount = createFinanceGoalDto.CurrentDebtAmount,
                //OutstandingAmount = createFinanceGoalDto.OutstandingAmount,
                //Goal = createFinanceGoalDto.Goal,
                //StartGoalDate = createFinanceGoalDto.StartGoalDate,
                //EndGoalDate = createFinanceGoalDto.EndGoalDate
            };
        }

        public static MoneyAccount ToMoneyAccountFromUpdateMoneyAccountDto(this UpdateMoneyAccountDto updateMoneyAccountDto)
        {
            return new MoneyAccount
            {
                //Code = updateFinanceGoalDto.Code,
                //SmallDescription = updateFinanceGoalDto.SmallDescription,
                //FullDescription = updateFinanceGoalDto.FullDescription,
                //CurrentDebtAmount = updateFinanceGoalDto.CurrentDebtAmount,
                //OutstandingAmount = updateFinanceGoalDto.OutstandingAmount,
                //Goal = updateFinanceGoalDto.Goal,
                //StartGoalDate = updateFinanceGoalDto.StartGoalDate,
                //EndGoalDate = updateFinanceGoalDto.EndGoalDate
            };
        }

        public static MoneyAccountDto ToMoneyAccountDtoFromMoneyAccount(this MoneyAccount moneyAccount)
        {
            return new MoneyAccountDto
            {
                //Id = financeGoal.Id,
                //Code = financeGoal.Code,
                //SmallDescription = financeGoal.SmallDescription,
                //FullDescription = financeGoal.FullDescription,
                //CurrentDebtAmount = financeGoal.CurrentDebtAmount,
                //OutstandingAmount = financeGoal.OutstandingAmount,
                //Goal = financeGoal.Goal,
                //StartGoalDate = financeGoal.StartGoalDate,
                //EndGoalDate = financeGoal.EndGoalDate
            };
        }

    }
}