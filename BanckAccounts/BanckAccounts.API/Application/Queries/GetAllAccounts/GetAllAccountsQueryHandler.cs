using BankAccounts.API.Application.Abstractions;
using BankAccounts.API.Application.Abstractions.Messaging;
using BankAccounts.API.Domain.Repositories;

namespace BankAccounts.API.Application.Queries.GetAllAccounts
{
    /// <summary>
    /// Query Handler for Get All Accounts Use Case
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public class GetAllAccountsQueryHandler(IBankAccountRepository bankAccountRepository) : 
        IQueryHandler<GetAllAccountsQuery, IEnumerable<GetAllAccountsQueryResponse>>
    {
        /// <summary>
        /// Handler method to execute Get All Accounts use case 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Result<IEnumerable<GetAllAccountsQueryResponse>>> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
        {
            var accounts = await bankAccountRepository.GetAll();

            var result = accounts.Select(account => new GetAllAccountsQueryResponse(account.Id,
                account.HolderName,
                account.Balance));

            return Result.Success(result);
        }
    }
}
