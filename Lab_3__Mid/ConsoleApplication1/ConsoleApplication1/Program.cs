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
            Console.WriteLine("Programm 1\n\n");

            Console.Write("Enter Number: ");
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if(i%2==0)
                    Console.WriteLine(i);

            Console.WriteLine("\n\nProgramm 4\n\n");

            int sumOfOdd = 0;
            int sumOfEven = 0;
            for (int i = 1; i <= 100; i++)
                if (i % 2 == 0)
                    sumOfEven += i;
                else
                    sumOfOdd += i;
            Console.WriteLine("Sum of Even Number: {0}\nSum of Odd Number: {1}", sumOfEven, sumOfOdd);

            Console.WriteLine("\n\nProgramm 8\n\n");

            double phy, chem, bio, math, com;
            Console.Write("Enter Physics Marks: ");
            phy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Chemistry Marks: ");
            chem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Biology Marks: ");
            bio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Mathematics Marks: ");
            math = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Computer Marks: ");
            com = Convert.ToDouble(Console.ReadLine());

            double avgMarks = (phy + chem + bio + math + com) / 5;
            string grade = "";

            if (avgMarks >= 90)
                grade = "A+";
            else if (avgMarks < 90 && avgMarks >= 85)
                grade = "A";
            else if (avgMarks < 85 && avgMarks >= 80)
                grade = "B+";
            else if (avgMarks < 80 && avgMarks >= 75)
                grade = "B";
            else if (avgMarks < 75 && avgMarks >= 50)
                grade = "C+";
            else
                grade = "F";

            Console.WriteLine("\nThe Grade is: " + grade);


            Console.ReadLine();
        }
    }
}
