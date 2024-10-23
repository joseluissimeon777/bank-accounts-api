using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Queries.GetAllAccounts
{
    /// <summary>
    /// Query model for Get All Accounts Use Case
    /// </summary>
    public class GetAllAccountsQuery():IQuery<IEnumerable<GetAllAccountsQueryResponse>>;
}
