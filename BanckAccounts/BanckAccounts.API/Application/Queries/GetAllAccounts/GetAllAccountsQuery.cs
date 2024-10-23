using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Queries.GetAllAccounts
{
    public class GetAllAccountsQuery():IQuery<IEnumerable<GetAllAccountsQueryResponse>>;
}
