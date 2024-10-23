namespace BankAccounts.API.Application.Queries.GetAllAccounts
{
    /// <summary>
    /// Response model for Get All Accounts use case
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="HolderName"></param>
    /// <param name="Balance"></param>
    public record GetAllAccountsQueryResponse(Guid Id, string HolderName,decimal Balance);
}
