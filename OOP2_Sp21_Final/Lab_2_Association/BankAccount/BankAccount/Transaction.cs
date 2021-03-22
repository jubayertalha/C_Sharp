using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Transaction
    {
        public Account Sender { get; private set; }
        public Account Receiver { get; private set; }
        public int Amount { get; private set; }
        public String AdditionalInfo { get; private set; }

        public Transaction() { }
        public Transaction(Account sender, Account receiver, int amount, String additionalInfo)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            AdditionalInfo = additionalInfo;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Sender: " + Sender.AccName);
            Console.WriteLine("Reciever: " + Receiver.AccName);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Additional Info: " + AdditionalInfo);
        }
    }
}
