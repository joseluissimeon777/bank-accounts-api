using BankAccounts.API.Domain;
using BankAccounts.API.Domain.Repositories;
using BankAccounts.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.API.Infrastructure.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly ApplicationDbContext _context;
        public BankAccountRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<BankAccount?> GetById(Guid id)
        {
            return await _context.Set<BankAccount>()
                .FirstOrDefaultAsync(account => account.Id == id);
        }

        public async Task<IEnumerable<BankAccount>> GetAll()
        {
            return await _context.Set<BankAccount>()
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task Update(BankAccount bankAccount)
        {
             _context.Set<BankAccount>().
               Update(bankAccount);
        
             await _context.SaveChangesAsync();
        }

        
    }
}
