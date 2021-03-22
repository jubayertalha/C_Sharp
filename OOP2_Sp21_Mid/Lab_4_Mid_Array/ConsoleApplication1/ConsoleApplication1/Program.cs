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
            //...............Program 1

            int n;//used in every program
            Console.WriteLine("\nProgram 1\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array1 = new int[n];
            Console.WriteLine("Enter Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.Write("Revers of the Array: ");
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            //...............Program 2

            Console.WriteLine("\nProgram 2\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array2 = new int[n];
            Console.WriteLine("Enter Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                array2[i] = Convert.ToInt16(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum += array2[i];
            }
            Console.WriteLine("Sum of the Array: " + sum);

            //...............Program 3

            Console.WriteLine("\nProgram 3\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array3 = new int[n];
            Console.WriteLine("Enter Array {0} Element: ", n);
            for (int i = 0; i < n; i++)
            {
                array3[i] = Convert.ToInt16(Console.ReadLine());
            }
            int[] anotherArray = new int[n];
            for (int i = 0; i < array3.Length; i++)
            {
                anotherArray[i] = array3[i];
            }
            Console.Write("Elements of another Array: ");
            for (int i = 0; i < anotherArray.Length; i++)
            {
                Console.Write(anotherArray[i] + " ");
            }
            Console.WriteLine();

            //...............Program 4

            Console.WriteLine("\nProgram 4\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array4 = new int[n];
            Console.WriteLine("Enter Array {0} Element(not negative numburs): ", n);
            for (int i = 0; i < n; i++)
            {
                array4[i] = Convert.ToInt16(Console.ReadLine());
            }
            int[,] countArray1 = new int[n, 2];
            int countArrayIndex = 0;
            for (int i = 0; i < array4.Length; i++)
            {
                int num = array4[i];
                if (num != -1)
                {
                    countArray1[countArrayIndex, 0] = num;
                    countArray1[countArrayIndex, 1]++;
                    for (int j = i + 1; j < array4.Length; j++ )
                    {
                        if (num == array4[j])
                        {
                            countArray1[countArrayIndex, 1]++;
                            array4[j] = -1;
                        }
                    }
                    countArrayIndex++;
                }
            }
            Console.WriteLine("Count of Duplicate Elements: ");
            for (int i = 0; i < countArrayIndex; i++)
            {
                Console.WriteLine("\t" + countArray1[i, 0] + " contains " + countArray1[i, 1] + " times.");
            }

            //...............Program 5

            Console.WriteLine("\nProgram 5\n");
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] array5 = new int[n];
            Console.WriteLine("Enter Array {0} Element(not negative numburs): ", n);
            for (int i = 0; i < n; i++)
            {
                array5[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < array5.Length; i++)
            {
                int num = array5[i];
                if (num != -1) 
                {
                    for (int j = i + 1; j < array5.Length; j++)
                    {
                        if (num == array5[j])
                        {
                            array5[j] = -1;
                        }
                    }
                }
                
            }
            Console.Write("Eunique Elements: ");
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] != -1)
                {
                    Console.Write(array5[i] + " ");
                }
            }
            Console.WriteLine();

            //...............END
            Console.WriteLine("\nEND\n");
            Console.ReadLine();
        }
    }
}
