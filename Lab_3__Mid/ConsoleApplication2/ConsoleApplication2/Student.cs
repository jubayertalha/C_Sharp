using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() 
        {
            Console.WriteLine("\n...Empty Student Object Created...\n");    
        }

        public void ShowIngo()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Department: " + department);
            Console.WriteLine("Student Cgpa: " + cgpa);
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }
        public float Cgpa
        {
            set
            {
                cgpa = value;
            }
            get
            {
                return cgpa;
            }
        }

    }
}
