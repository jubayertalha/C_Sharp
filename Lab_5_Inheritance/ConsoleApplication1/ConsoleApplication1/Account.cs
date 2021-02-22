using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Account
    {
        private string name;
        private string id;
        protected int balance;

        public Account() { }

        public Account(string name, string id, int balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        abstract public void Transfer(int amount, Account acc);

        virtual public int AccountAge { get; set; }
    }
}
