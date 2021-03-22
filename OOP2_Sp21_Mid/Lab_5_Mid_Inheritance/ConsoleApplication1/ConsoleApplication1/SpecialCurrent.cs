using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SpecialCurrent : Account
    {
        readonly int openingBalance;
        readonly int minBalance;

        public SpecialCurrent(string name, string id, int balance)
            : base(name, id, balance)
        {
            this.openingBalance = balance;
            this.minBalance = (int)(openingBalance/100)*10;
        }
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
