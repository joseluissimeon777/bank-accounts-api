using BankAccounts.API.Domain;
using BankAccounts.API.Domain.Repositories;
using BankAccounts.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.API.Infrastructure.Repositories
{
    /// <summary>
    /// Implementation of repository for BankAccount´s operations
    /// </summary>
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly ApplicationDbContext _context;
        public BankAccountRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        /// <summary>
        /// Get Bank Account By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<BankAccount?> GetById(Guid id)
        {
            return await _context.Set<BankAccount>()
                .FirstOrDefaultAsync(account => account.Id == id);
        }

        /// <summary>
        /// Get All Bank Accounts
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BankAccount>> GetAll()
        {
            return await _context.Set<BankAccount>()
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <param name="bankAccount"></param>
        /// <returns></returns>
        public async Task Update(BankAccount bankAccount)
        {
             _context.Set<BankAccount>().
               Update(bankAccount);
        
             await _context.SaveChangesAsync();
        }

        
    }
}
