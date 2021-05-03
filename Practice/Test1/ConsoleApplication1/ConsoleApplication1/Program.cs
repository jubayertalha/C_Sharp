using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
         public delegate void Calc(int x, int y);

        public static void Add(int a, int c) {
            Console.Write("Sum: " + (a + c));
        }
        public static void Sub(int a, int c) {
            Console.Write("Sub: " + (a - c));
    }
         public static void Multiply(int x, int y)
{
            Console.Write("Multiply: " + (x * y));
         }
        public static void Div(int x, int y)
        {
            Console.Write("Division: " + (x / y));
        }
        static void Main(string[] args)
        {
               Calc adder = Multiply;
               adder(3,4);
               adder -= Multiply;
               adder += Sub;
               adder   += Add;
               adder    -= Add;
               adder += Multiply;
               adder(4,5);
               Console.ReadLine();

        }
    }

    }

