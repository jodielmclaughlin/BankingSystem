using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class BankAccount
    {
        public int AccountNumber { get; }
        public string OwnerName { get; }
        public int Balance { get; set; }
        public int AgreedOverdraft { get; set; }

        public BankAccount(int accountNumber, string ownerName, int balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
            AgreedOverdraft = 50;
        }

        public void DepositMoney(int amount)
        {
            Balance += amount;
        }

        public void WithdrawMoney(int amount)
        {
            
            if (Balance - amount < -AgreedOverdraft)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {
                Balance -= amount;
                
            }
        }

    }
}
