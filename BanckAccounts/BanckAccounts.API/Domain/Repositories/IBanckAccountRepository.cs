using BankAccounts.API.Domain;

namespace BankAccounts.API.Domain.Repositories
{
    /// <summary>
    /// Abstraction of repository for BankAccount´s operations
    /// </summary>
    public interface IBankAccountRepository
    {
        /// <summary>
        /// Get Bank Account By Id
        /// </summary>
        /// <param name="id"></param>
        Task<BankAccount?> GetById(Guid id);

        /// <summary>
        /// Get All Bank Accounts
        /// </summary>
        /// <returns></returns>
        Task Update(BankAccount bankAccount);

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <param name="bankAccount"></param>
        /// <returns></returns>
        Task<IEnumerable<BankAccount>> GetAll();

    }
}
