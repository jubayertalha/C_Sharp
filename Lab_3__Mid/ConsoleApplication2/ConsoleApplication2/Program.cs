using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //................................Student

            Student student = new Student();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter ID: ");
            student.Id = Console.ReadLine();

            Console.Write("Enter Department: ");
            student.Department = Console.ReadLine();

            Console.Write("Enter CGPA: ");
            student.Cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            student.ShowIngo();

            //................................Triangle

            Triangle triangle = new Triangle();

            Console.Write("Enter X: ");
            triangle.X = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Y: ");
            triangle.Y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Z: ");
            triangle.Z = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            triangle.ShowInfo();

            //................................Account

            Account account = new Account();

            Console.Write("Enter Account Name: ");
            account.AccName = Console.ReadLine();

            Console.Write("Enter Account ID: ");
            account.Acid = Console.ReadLine();

            Console.Write("\nEnter Deposit Amount: ");
            account.Deposit(Convert.ToInt16(Console.ReadLine()));

            Console.Write("\nEnter Withdraw Amount: ");
            account.Withdraw(Convert.ToInt16(Console.ReadLine()));

            //................................Course

            Course course = new Course();

            Console.Write("Enter Course Name: ");
            course.CourseName = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            course.CourseCode = Console.ReadLine();

            Console.Write("Enter Course Credit: ");
            course.CourseCredit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            course.ShowCourseInfo();


            //............END
            Console.WriteLine("\n\nEnd!");
            Console.ReadLine();
        }
    }
}
