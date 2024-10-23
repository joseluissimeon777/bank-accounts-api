using BankAccounts.API.Domain;

namespace BankAccounts.API.Domain.Repositories
{
    public interface IBankAccountRepository
    {
        Task<BankAccount?> GetById(Guid id);
        Task Update(BankAccount bankAccount);
        Task<IEnumerable<BankAccount>> GetAll();

    }
}
