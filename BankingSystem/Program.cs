namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount(65431, "Jodie McLaughlin", 5000);

            Console.WriteLine("Account number: " + newAccount.AccountNumber);
            Console.WriteLine("Account owner: " + newAccount.OwnerName);
            Console.WriteLine("Account balance: " + newAccount.Balance);

        }
    }
}
