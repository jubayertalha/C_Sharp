using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; private set; }
        public double Balance { get; set; }
        public Transaction[] listOfTransaction;
        public int TotalNumberOfTransactions { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance) {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            listOfTransaction = new Transaction[100];
            TotalNumberOfTransactions = 0;
        }
        public void AddTransaction(Account sender, Account receiver, int amount, String additionalInfo)
        {
            Transaction transaction = new Transaction(sender, receiver, amount, additionalInfo);
            listOfTransaction[TotalNumberOfTransactions++] = transaction;
        }
        public void ShowAllTransaction()
        {
            Console.WriteLine("\nAll Transaction of Account {0}({1}): \n", AccName, AccNo);
            for (int i = 0; i < TotalNumberOfTransactions; i++)
            {
                Console.WriteLine();
                listOfTransaction[i].ShowInfo();
                Console.WriteLine();
            }
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            AddTransaction(this, this, (int)amount, "Self Deposite");
        }
        public void ShowInfo() {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
            ShowAllTransaction();
        }
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Your acc has been debited by {0} to self", amount);
                AddTransaction(this, this, (int)amount, "Self Withdraw");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void Transfer(Account acc, double amount)
        {
            if (amount <= Balance)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
                AddTransaction(this, acc, (int)amount, "Send Money");
                AddTransaction(acc, this, (int)amount, "Recieved Money");
            }
        }

    }
}
