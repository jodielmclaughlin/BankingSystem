Repo for a C# exercise - Banking System.
Task is to create a banking system using C# classes to model different parts of the real world. Your system should contain the following classes:
- BankAccount, which contains an AccountNumber, Balance and OwnerName, as well as methods for depositing and withdrawing up to an AgreedOverdraft amount.
- BankTransaction, which contains a transactionId, type, amount and timestamp. This class should be immutable. Look into what this means and how you might implement it.
- BankingSystem which has the ability to create accounts, list accounts, perform transactions such as deposits and withdrawals, as well as list transaction history for an account.

Add additional functionality
- Create a notification class which is notified whenever a large transaction is performed on any account. The BankingSystem should be able to print a history of large transaction notifications.
- Give the BankingSystem an interest rate that can be get/set, and a method which adds interest to all of the bank accounts.
- Add categories to the BankTransaction class such as "Groceries" or "Entertainment". Allow the BankAccount to get a list of transactions by category.
- Add a monthly transaction limit to each account that can be set by the BankingSystem. This limit should be checked on each deposit/withdrawal to check that the limit for that month hasn't been reached.
- Add an AccountOwner class and remove the OwnerName property from BankAccount. Add suitable properties to the new account owner class. Allow BankAccount to instead have a List of AccountOwner to support joint accounts.
