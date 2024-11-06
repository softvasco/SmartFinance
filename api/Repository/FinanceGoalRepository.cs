using api.Data;
using shared.DTOs.FinanceGoals;
using api.Helpers;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class FinanceGoalRepository : IFinanceGoalRepository
    {
        private int _userId;
        private readonly ApplicationDBContext _context;

        public FinanceGoalRepository(ApplicationDBContext context)
        {
            _context = context;
            _userId = _context.Users.First(x=>x.Username=="vasco.silva").Id;
        }

        public async Task<List<FinanceGoalDto>> GetAsync()
        {
            var financeGoals = await _context.FinanceGoals
             .Where(x => x.IsActive && x.UserId==_userId)
             .ToListAsync();

            return financeGoals.Select(c => c.ToFinanceGoalDtoFromFinanceGoal()).ToList();
        }

        public async Task<FinanceGoal> CreateAsync(FinanceGoal financeGoal)
        {
            if (_context
                .FinanceGoals
                .AsNoTracking()
                .Any(x => x.Code == financeGoal.Code
                    && x.IsActive
                    && x.UserId == _userId))
                throw new Exception("Finance Goal already exists!");

            financeGoal.UserId = _userId;
            financeGoal.CreatedDate = DateTime.Now;
            financeGoal.UpdatedDate = DateTime.Now;
            financeGoal.IsActive = true;

            await _context.FinanceGoals.AddAsync(financeGoal);
            await _context.SaveChangesAsync();
            return financeGoal;
        }

        public async Task<FinanceGoal> UpdateAsync(int id, FinanceGoal financeGoal)
        {
            FinanceGoal? existingFinanceGoal 
                = await _context
                    .FinanceGoals
                    .FindAsync(id) ?? throw new Exception("Finance Goal does not exists!");

            existingFinanceGoal.Code = financeGoal.Code;
            existingFinanceGoal.SmallDescription = financeGoal.SmallDescription;
            existingFinanceGoal.FullDescription = financeGoal.FullDescription;
            existingFinanceGoal.OutstandingAmount = financeGoal.OutstandingAmount;
            existingFinanceGoal.CurrentDebtAmount = financeGoal.CurrentDebtAmount;
            existingFinanceGoal.Goal = financeGoal.Goal;
            existingFinanceGoal.StartGoalDate = financeGoal.StartGoalDate;
            existingFinanceGoal.EndGoalDate = financeGoal.EndGoalDate;

            existingFinanceGoal.UpdatedDate = DateTime.Now;

            try
            {
                _context.Entry(existingFinanceGoal).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return existingFinanceGoal;
        }

        public async Task<FinanceGoal> DeleteAsync(int id)
        {
            var existingFinanceGoal = await _context
              .FinanceGoals
              .AsNoTracking()
              .FirstOrDefaultAsync(x => x.Id == id
                && x.IsActive
                && x.UserId == _userId) ?? throw new NotFoundException("Finance Goal not found");

            existingFinanceGoal.UpdatedDate = DateTime.Now;
            existingFinanceGoal.IsActive = false;

            try
            {
                _context.Entry(existingFinanceGoal).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return existingFinanceGoal;
        }

    }
}