using BankAccounts.API.Application.Abstractions;
using BankAccounts.API.Application.Abstractions.Messaging;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain.Repositories;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.API.Application.Queries.GetBalanceAccount
{
    public class GetBalanceAccountQueryHandler(IBankAccountRepository bankAccountRepository) : IQueryHandler<GetBalanceAccountQuery, GetBalanceAccountResponse>
    {
        public async Task<Result<GetBalanceAccountResponse>> Handle(GetBalanceAccountQuery request, CancellationToken cancellationToken)
        {
            var bankAccount = await bankAccountRepository.GetById(request.AccountId);

            if (bankAccount == null)
                return Result.Failure<GetBalanceAccountResponse>(BankAccountErrors.NotFound);
          
            return  new GetBalanceAccountResponse(request.AccountId,bankAccount!.Balance);
        }
    }
}
