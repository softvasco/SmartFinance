using Shared.DTOs.FinanceGoals;
using api.Models;

namespace api.Mappers
{
    public static class FinanceGoalMappers
    {
        public static FinanceGoal ToFinanceGoalFromCreateFinanceGoalDto(this CreateFinanceGoalDto createFinanceGoalDto)
        {
            return new FinanceGoal
            {
                Code = createFinanceGoalDto.Code,
                SmallDescription = createFinanceGoalDto.SmallDescription,
                FullDescription = createFinanceGoalDto.FullDescription,
                CurrentDebtAmount = createFinanceGoalDto.CurrentDebtAmount,
                OutstandingAmount = createFinanceGoalDto.OutstandingAmount,
                Goal = createFinanceGoalDto.Goal,
                StartGoalDate = createFinanceGoalDto.StartGoalDate,
                EndGoalDate = createFinanceGoalDto.EndGoalDate
            };
        }

        public static FinanceGoal ToFinanceGoalFromUpdateFinanceGoalDto(this UpdateFinanceGoalDto updateFinanceGoalDto)
        {
            return new FinanceGoal
            {
                Code = updateFinanceGoalDto.Code,
                SmallDescription = updateFinanceGoalDto.SmallDescription,
                FullDescription = updateFinanceGoalDto.FullDescription,
                CurrentDebtAmount = updateFinanceGoalDto.CurrentDebtAmount,
                OutstandingAmount = updateFinanceGoalDto.OutstandingAmount,
                Goal = updateFinanceGoalDto.Goal,
                StartGoalDate = updateFinanceGoalDto.StartGoalDate,
                EndGoalDate = updateFinanceGoalDto.EndGoalDate
            };
        }

        public static FinanceGoalDto ToFinanceGoalDtoFromFinanceGoal(this FinanceGoal financeGoal)
        {
            return new FinanceGoalDto
            {
                Id = financeGoal.Id,
                Code = financeGoal.Code,
                SmallDescription = financeGoal.SmallDescription,
                FullDescription = financeGoal.FullDescription,
                CurrentDebtAmount = financeGoal.CurrentDebtAmount,
                OutstandingAmount = financeGoal.OutstandingAmount,
                Goal = financeGoal.Goal,
                StartGoalDate = financeGoal.StartGoalDate,
                EndGoalDate = financeGoal.EndGoalDate
            };
        }

    }
}