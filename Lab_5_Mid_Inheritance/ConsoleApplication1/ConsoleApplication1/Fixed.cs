using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fixed : Account
    {
        private int tenurYear;
        private int accountAge;

        public override int AccountAge
        {
            set { this.accountAge = value; }
        }

        public Fixed(string name, string id, int balance, int tenurYear)
            : base(name, id, balance)
        {
            this.tenurYear = tenurYear;
            this.accountAge = 0;
        }

        public override void Transfer(int amount, Account acc)
        {
            if (tenurYear<=accountAge && amount<=balance)
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
