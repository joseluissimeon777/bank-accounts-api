namespace BankAccounts.API.Application.Queries.GetAllAccounts
{
    public record GetAllAccountsQueryResponse(Guid Id, string HolderName,decimal Balance);
}
