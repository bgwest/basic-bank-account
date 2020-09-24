using System;

namespace oopintrotoclasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Vinicio", 1000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.\n");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            // TODO: anyway to make the withdraw amount and note item variables?
            Console.WriteLine($"Account {account.Number} withdrew 120 for hammock\n");

            Console.WriteLine(account.GetAccountHistory());

            // Uncomment to test exceptions
            //try
            //{
            //    var invaildAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.Write("Exception caught creating account with negative balance.");
            //    Console.Write(e.ToString());
            //}

            Console.WriteLine($"\nNew account balance: {account.Balance}");
        }
    }
}
