using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Account a01 = new Savings("Sheikh", "012364", 403400);
            a01.Transfer(5000, a01);

            Account a02 = new SpecialCurrent("Talha", "016754", 40000);
            a02.Transfer(36000, a02);

            Account a03 = new Fixed("Jubayer", "014564", 5563000, 5);
            a03.AccountAge = 5;
            a03.Transfer(34000, a03);

            Account a04 = new OverDraft("Rahman", "012957", 56000, 10000);
            a04.Transfer(60000, a04);

            Console.ReadLine();

        }
    }
}
