using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OverDraft:Account
    {
        private int limit;

        public OverDraft(string name, string id, int balance, int limit)
            : base(name, id, balance)
        {
            this.limit = limit;
        }

        public override void Transfer(int amount, Account acc)
        {
            if ((balance+limit)>=amount)
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
