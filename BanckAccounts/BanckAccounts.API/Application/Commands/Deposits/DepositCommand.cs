using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Commands.Deposits
{
    /// <summary>
    /// Command model for Deposit Use Case
    /// </summary>
    /// <param name="AccountId"></param>
    /// <param name="Amount"></param>
    public record DepositCommand(Guid AccountId, decimal Amount)
        :ICommand;  
}
