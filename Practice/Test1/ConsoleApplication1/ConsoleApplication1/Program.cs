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
            /*int i;
            string name = "Talha";

            for (i = 0; i < 10; i++) 
                if(i%2==1)
                    Console.WriteLine("Hello {0} {1}!",name,i);

            int x, y;

            try
            {
                Console.Write("Enter x: ");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter y: ");
                y = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\nAddition is {0}\nSubtraction is {1}\nMultiplication is {2}\nDivision is {3}", (x + y), (x - y), (x * y), (x / y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/


            int i;
            int b = 32, a = 40;
            for (i = 1; i <= 9; i++)
            {
                if ((a / b * 2) == 2)
                {
                    Console.WriteLine(i + " ");
                    continue;
                }
                else if (i != 4)
                    Console.Write(i + " ");
                else
                    break;
            }

            
            Console.ReadLine();
        }
    }
}
