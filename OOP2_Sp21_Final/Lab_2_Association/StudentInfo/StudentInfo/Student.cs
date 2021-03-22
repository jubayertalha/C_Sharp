using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Student
    {
        string name;
        string id;
        double cgpa;
        Department dept;

        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public Student(string name, string id, double cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Department: " + dept.Name);
            Console.WriteLine("***************");
        }
    }
}
