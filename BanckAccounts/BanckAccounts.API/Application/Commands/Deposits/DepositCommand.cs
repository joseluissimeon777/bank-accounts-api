using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Commands.Deposits
{
    public record DepositCommand(Guid AccountId, decimal Amount)
        :ICommand;  
}
