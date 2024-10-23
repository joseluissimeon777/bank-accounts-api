using BankAccounts.API.Application.Abstractions;
using BankAccounts.API.Application.Abstractions.Messaging;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain.Repositories;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.API.Application.Queries.GetBalanceAccount
{
    /// <summary>
    /// Query Handler for Get Balance Account Use Case
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public class GetBalanceAccountQueryHandler(IBankAccountRepository bankAccountRepository) : IQueryHandler<GetBalanceAccountQuery, GetBalanceAccountResponse>
    {
        /// <summary>
        /// Handler method to execute Get Balance Account Use Case 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Result<GetBalanceAccountResponse>> Handle(GetBalanceAccountQuery request, CancellationToken cancellationToken)
        {
            var bankAccount = await bankAccountRepository.GetById(request.AccountId);

            if (bankAccount == null)
                return Result.Failure<GetBalanceAccountResponse>(BankAccountErrors.NotFound);
          
            return  new GetBalanceAccountResponse(request.AccountId,bankAccount!.Balance);
        }
    }
}
