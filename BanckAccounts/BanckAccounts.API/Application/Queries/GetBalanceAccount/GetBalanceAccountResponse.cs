namespace BankAccounts.API.Application.Queries.GetBalanceAccount
{
    /// <summary>
    /// Response model for Get Balance Account Use Case
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Balance"></param>
    public record GetBalanceAccountResponse(Guid Id, decimal Balance);
}
