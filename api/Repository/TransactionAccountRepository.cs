using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class TransactionAccountRepository : ITransactionAccountRepository
    {
        private readonly ApplicationDBContext _context;

        public TransactionAccountRepository(ApplicationDBContext context)
        {
            _context = context;
        }

       
    }
}
