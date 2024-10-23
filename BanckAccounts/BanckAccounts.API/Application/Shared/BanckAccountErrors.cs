using BankAccounts.API.Application.Abstractions;

namespace BankAccounts.API.Application.Shared
{
    public static class BankAccountErrors
    {
        public readonly static Error NotFound = new("Account.NotFound", "La cuenta no existe");
        public readonly static Error NotEnoughMoney = new("Account.NotHas", "La cuenta tiene dinero insuficiente");


    }
}
