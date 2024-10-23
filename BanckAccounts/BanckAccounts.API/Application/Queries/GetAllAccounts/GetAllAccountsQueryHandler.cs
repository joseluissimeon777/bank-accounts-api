using BankAccounts.API.Application.Abstractions;
using BankAccounts.API.Application.Abstractions.Messaging;
using BankAccounts.API.Domain.Repositories;

namespace BankAccounts.API.Application.Queries.GetAllAccounts
{
    public class GetAllAccountsQueryHandler(IBankAccountRepository bankAccountRepository) : 
        IQueryHandler<GetAllAccountsQuery, IEnumerable<GetAllAccountsQueryResponse>>
    {
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
