﻿using BankAccounts.API.Application.Abstractions;
using BankAccounts.API.Application.Abstractions.Messaging;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain.Repositories;

namespace BankAccounts.API.Application.Commands.WithDraws
{
    /// <summary>
    /// Command Handler for withdraw use case
    /// </summary>
    /// <param name="bankAccountRepository"></param>
    public class WithDrawCommandHandler(IBankAccountRepository bankAccountRepository) : ICommandHandler<WithDrawCommand>
    {
        /// <summary>
        /// Handle method for execute withdraws
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Result> Handle(WithDrawCommand request, CancellationToken cancellationToken)
        {
            var bankAccount = await bankAccountRepository.GetById(request.AccountId);

            if (bankAccount == null)
                return Result.Failure(BankAccountErrors.NotFound);

            if (bankAccount!.Balance <= 0)
                return Result.Failure(BankAccountErrors.NotEnoughMoney);

            bankAccount!.WithDrawMoney(request.Amount);

            await bankAccountRepository.Update(bankAccount);

            return Result.Success();
        }
    }
}
