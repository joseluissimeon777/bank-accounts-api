using BankAccounts.API.Application.Abstractions;
using BankAccounts.API.Application.Abstractions.Messaging;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain;
using BankAccounts.API.Domain.Repositories;

namespace BankAccounts.API.Application.Commands.Deposits
{
    public class DepositCommandHandler(IBankAccountRepository bankAccountRepository) : ICommandHandler<DepositCommand>
    {
        public async Task<Result> Handle(DepositCommand request, CancellationToken cancellationToken)
        {
            var bankAccount = await bankAccountRepository.GetById(request.AccountId);

            if (bankAccount == null)
                return Result.Failure(BankAccountErrors.NotFound);

            bankAccount!.DepositMoney(request.Amount);

            await bankAccountRepository.Update(bankAccount);

            return Result.Success();
        }

    }
}
