using BankAccounts.API.Application.Queries.GetBalanceAccount;
using BankAccounts.API.Application.Shared;
using BankAccounts.API.Domain;
using BankAccounts.API.Domain.Repositories;
using BankAccounts.Test.Mocks;
using FakeItEasy;

namespace BankAccounts.Test.Application
{
    public class GetBalanceAccountTest
    {

        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly GetBalanceAccountQueryHandler _handler;
        private readonly GetBalanceAccountQuery _query;

        public GetBalanceAccountTest()
        {
            _bankAccountRepository = A.Fake<IBankAccountRepository>();
            _query = new GetBalanceAccountQuery(Guid.NewGuid());
            _handler = new GetBalanceAccountQueryHandler(_bankAccountRepository);
        }

        [Fact]
        public async Task Handler_AccountExist_ReturnSuccess()
        {
            var accountMock = BankAccountMock.GetDefaultAccount();

            A.CallTo(() => _bankAccountRepository.GetById(
                accountMock.Id)).Returns(Task.FromResult<BankAccount?>(accountMock));

            var result = await _handler.Handle(_query, default);

            Assert.True(result.IsSuccess);
            Assert.IsType<GetBalanceAccountResponse>(result.Value);
        }

        [Fact]
        public async Task Handler_AccountNotExist_ReturnFailure()
        {
            A.CallTo(() => _bankAccountRepository.GetById(
                _query.AccountId)).Returns(Task.FromResult<BankAccount?>(null));

            var result = await _handler.Handle(_query, default);

            Assert.Equal(BankAccountErrors.NotFound, result.Error);
        }

    }
}
