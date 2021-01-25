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
            int i;
            string name = "Talha";

            for (i = 0; i < 10; i++) 
                if(i%2==1)
                    Console.WriteLine("Hello "+name+" "+i);

            Console.ReadLine();
        }
    }
}
