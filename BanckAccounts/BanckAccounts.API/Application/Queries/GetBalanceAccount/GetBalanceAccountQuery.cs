using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Queries.GetBalanceAccount
{
    /// <summary>
    /// Query model for Get Balance Account Use Case
    /// </summary>
    /// <param name="AccountId"></param>
    public record GetBalanceAccountQuery(Guid AccountId) : IQuery<GetBalanceAccountResponse>;
   
}
