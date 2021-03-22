using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Talha Jubayer","145",50000);
            Account a2 = new Account("Jubayer Talha","146", 50000);

            a1.Withdraw(20000);
            a1.Deposit(10000);
            a1.Transfer(a2, 30000);
            a2.Transfer(a1, 15000);

            Console.WriteLine("\n******************************\n");
            a1.ShowInfo();
            Console.WriteLine("******************************\n");
            a2.ShowInfo();

            Console.Write("End");
            Console.ReadLine();
        }
    }
}
