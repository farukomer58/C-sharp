using System;
using System.Collections.Generic;
using System.Text;

namespace Bank {
    class BankAccount {

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get {
                // Getter for this attribute
                decimal balance = 0;
                foreach (var item in transactions) {
                    balance+=item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        // List that holds all the transaction done
        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(string owner, decimal initialBalance) {
            this.Owner=owner;
            this.MakeDeposit(initialBalance,DateTime.Now,"Initial Deposit");

            // Generate ID for each new Bank
            this.Number=accountNumberSeed.ToString();
            accountNumberSeed++;

            Console.WriteLine($"New Bank account {this.Number} created for {this.Owner} with {this.Balance} money");
        }

        // MAKE Positive transaction
        public void MakeDeposit(decimal amount, DateTime date, string note) {
            if (amount<=0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            transactions.Add(deposit);
        }
        
        // MAKE Negative transaction
        public void MakeWithdrawal(decimal amount, DateTime date, string note) {
            if (amount<=0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance-amount<0) {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            transactions.Add(withdrawal);
        }

        // Get overview of all transactions done
        public string getTransactionHistory() {
            var report = new StringBuilder();

            decimal balance = 0;
            // Header/COLUMNS
            report.Append("Date\t\tAmount\tReason\t\t\tBalance\n");
            foreach (var item in transactions) {
                // ROWS
                balance+=item.Amount;
                report.Append($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}\t\t{balance}\n");
            }
            return report.ToString();
        }

    }
}
