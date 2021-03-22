using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE");
            Department d2 = new Department("EEE");

            Student s1 = new Student("Talha", "19-41468-3", 3.90);
            Student s2 = new Student("Jubayer", "19-4143-3", 3.60);
            Student s3 = new Student("Rahman", "19-41439-3", 3.30);
            Student s4 = new Student("Sheikh", "19-41426-3", 2.70);

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.ReadLine();
        }
    }
}
