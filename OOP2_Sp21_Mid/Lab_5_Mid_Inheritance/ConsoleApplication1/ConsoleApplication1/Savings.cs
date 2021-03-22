using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Savings : Account
    {
        private const int minBalance = 430;

        public Savings(string name, string id, int balance) : base(name, id, balance) { }

        public override void Transfer(int amount, Account acc)
        {
            if ((balance - amount) >= minBalance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine("Successfull : New Balance : " + balance);
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
