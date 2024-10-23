using BankAccounts.API.Domain;
using BankAccounts.Test.Mocks;

namespace BankAccounts.Test.Domain
{
    public class BankAccountTest
    {
        [Fact]
        public void Create_NewBankAccountWithHolderNameAndDefaultBalance()
        { 
            var bankAccount = BankAccount.Create("Raúl Gomez");

            Assert.Equal("Raúl Gomez", bankAccount.HolderName);
            Assert.Equal(0, bankAccount.Balance);
        }

        [Fact]
        public void DepositMoney_IncrementBalanceAmount()
        {
            decimal amount = 100;

            var bankAccount = BankAccountMock.GetAccountWithBalance();

            bankAccount.DepositMoney(amount);

            Assert.Equal(200, bankAccount.Balance);
        }

        [Fact]
        public void WithDrawMoney_IncrementBalanceAmount()
        {
            decimal amount = 100;

            var bankAccount = BankAccountMock.GetAccountWithBalance();

            bankAccount.WithDrawMoney(amount);

            Assert.Equal(0, bankAccount.Balance);
        }


    }
}