using BankAccounts.API.Domain;

namespace BankAccounts.Test.Mocks
{
    public static class BankAccountMock
    {
        public static BankAccount GetDefaultAccount() 
        {
            return BankAccount.Create("Raúl Gomez");
        }

        public static BankAccount GetAccountWithBalance()
        {
            var account = BankAccount.Create("Raúl Gomez");

            account.DepositMoney(100);

            return account;
        }
    }
}
