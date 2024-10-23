using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Commands.WithDraws
{
    /// <summary>
    /// Command model for With Draw Use Case
    /// </summary>
    /// <param name="AccountId"></param>
    /// <param name="Amount"></param>
    public record WithDrawCommand(Guid AccountId, decimal Amount)
        :ICommand; 
}
