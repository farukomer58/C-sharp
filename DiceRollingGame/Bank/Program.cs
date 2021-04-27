using System;

namespace Bank {
    class Program {
        static void Main(string[] args) {

            var account = new BankAccount("Omer", 1000);

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.getTransactionHistory());

        }
    }
}
