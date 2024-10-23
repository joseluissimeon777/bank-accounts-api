using BankAccounts.API.Application.Commands.WithDraws;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain;
using BankAccounts.API.Domain.Repositories;
using BankAccounts.Test.Mocks;
using FakeItEasy;

namespace BankAccounts.Test.Application
{
    public class WithDrawTest
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly WithDrawCommandHandler _handler;
        private readonly WithDrawCommand _command;
        public WithDrawTest()
        {
            _bankAccountRepository = A.Fake<IBankAccountRepository>();
            _command = new WithDrawCommand(Guid.NewGuid(), 100);
            _handler = new WithDrawCommandHandler(_bankAccountRepository);
        }

        [Fact]
        public async Task Handler_AccountNotExist_ReturnFailure()
        {
            A.CallTo(() => _bankAccountRepository.GetById(
                _command.AccountId)).Returns(Task.FromResult<BankAccount?>(null));

            var result = await _handler.Handle(_command, default);

            Assert.Equal(BankAccountErrors.NotFound, result.Error);
        }

        [Fact]
        public async Task Handler_AccountHasNotEnoughMoney_ReturnFailure()
        {
            var mockAccount = BankAccountMock.GetDefaultAccount();

            A.CallTo(() => _bankAccountRepository.GetById(
                mockAccount.Id)).Returns(Task.FromResult<BankAccount?>(mockAccount));

            var result = await _handler.Handle(_command, default);

            Assert.Equal(BankAccountErrors.NotEnoughMoney, result.Error);
        }



        [Fact]
        public async Task Handler_AccountExistAndHasEnoughMoney_ReturnSuccess()
        {   
            var accountMock = BankAccountMock.GetAccountWithBalance();

            A.CallTo(() => _bankAccountRepository.GetById(
                _command.AccountId)).Returns(Task.FromResult<BankAccount?>(accountMock));

            var result = await _handler.Handle(_command, default);

            Assert.True(result.IsSuccess);
        }
    }
}
