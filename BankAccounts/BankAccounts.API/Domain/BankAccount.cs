using System.Runtime.CompilerServices;

namespace BankAccounts.API.Domain
{
    /// <summary>
    /// Bank Account Entity
    /// </summary>
    public class BankAccount
    {
        public Guid Id { get; set; }
        public string HolderName { get; set; } = string.Empty; 
        public decimal Balance { get; set; }       

        public void DepositMoney(decimal moneyQuantity) 
        {
            Balance += moneyQuantity;
        }

        public void WithDrawMoney(decimal moneyQuantity)
        {
            Balance -= moneyQuantity;
        }

        public static BankAccount Create(string HolderName) 
        { 
             return new BankAccount { Id = Guid.NewGuid(), HolderName = HolderName };
        }
        public static BankAccount Of(Guid id,decimal balance) 
        {
            return new BankAccount {Id = id, Balance = balance };
        }
    }
}
