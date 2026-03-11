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
        public int Balance { get; }

        public BankAccount(int accountNumber, string ownerName, int balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

    }
}
