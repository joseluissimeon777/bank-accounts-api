using BankAccounts.API.Application.Commands.Deposits;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain;
using BankAccounts.API.Domain.Repositories;
using BankAccounts.Test.Mocks;
using FakeItEasy;

namespace BankAccounts.Test.Application
{
    public class DepositTest
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly DepositCommandHandler _handler;
        private readonly DepositCommand _command;
        public DepositTest()
        {
            _bankAccountRepository = A.Fake<IBankAccountRepository>();
            _command = new DepositCommand(Guid.NewGuid(), 100);
            _handler = new DepositCommandHandler(_bankAccountRepository);
        }

        [Fact]
        public async Task Handler_AccountNotExist_ReturnFailure() 
        {   
            A.CallTo(() => _bankAccountRepository.GetById(_command.AccountId))
                .Returns(Task.FromResult<BankAccount?>(null));

            var result = await _handler.Handle(_command, default);

            Assert.Equal(BankAccountErrors.NotFound.Message, result.Error.Message);
        }


        [Fact]
        public async Task Handler_AccountExist_ReturnSuccess()
        {
            var accountMock = BankAccountMock.GetDefaultAccount();

            A.CallTo(() => _bankAccountRepository.GetById(
                accountMock.Id)).Returns(Task.FromResult<BankAccount?>(accountMock));

            var result = await _handler.Handle(_command, default);

            Assert.True(result.IsSuccess);
        }


    }
}
