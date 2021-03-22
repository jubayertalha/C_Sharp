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

            Course c1 = new Course("OOP 2", "oop2m");
            Course c2 = new Course("Math 5", "math5k");
            Course c3 = new Course("IEC", "iecl");
            Course c4 = new Course("BS", "bsp");
            Course c5 = new Course("ALGO", "algol");
            Course c6 = new Course("OOAD", "ooada");

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.WriteLine("\n_____________________\n\nAdding Droping\n\n_____________________\n");

            s1.AddCourse(c1);
            s1.AddCourse(c2);
            s1.AddCourse(c3);
            s1.AddCourse(c4);
            s1.AddCourse(c5);
            s1.AddCourse(c6);

            s1.DropCourse(c5);

            s1.AddCourse(c1);
            s1.AddCourse(c6);

            s2.AddCourse(c1);
            s3.AddCourse(c1);
            s4.AddCourse(c1);

            s1.ShowCourses();
            s2.ShowCourses();

            c1.ShowStudents();
            c2.ShowStudents();

            Console.ReadLine();
        }
    }
}
