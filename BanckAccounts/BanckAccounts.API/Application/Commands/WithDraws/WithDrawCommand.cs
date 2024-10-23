using BankAccounts.API.Application.Abstractions.Messaging;

namespace BankAccounts.API.Application.Commands.WithDraws
{
    public record WithDrawCommand(Guid AccountId, decimal Amount)
        :ICommand; 
}
