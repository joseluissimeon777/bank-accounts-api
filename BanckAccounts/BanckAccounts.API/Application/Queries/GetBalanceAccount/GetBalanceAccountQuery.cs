using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Queries.GetBalanceAccount
{
    public record GetBalanceAccountQuery(Guid AccountId) : IQuery<GetBalanceAccountResponse>;
   
}
