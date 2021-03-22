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
        public string Id {get;private set;}
        double cgpa;
        Department dept;
        private Course[] courses;
        public int MaxCourseLimit { get; private set; }
        public int TotalCourses { get; private set; }

        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public Student(string name, string id, double cgpa)
        {
            this.name = name;
            this.Id = id;
            this.cgpa = cgpa;
            MaxCourseLimit = 5;
            TotalCourses = 0;
            courses = new Course[MaxCourseLimit];
        }

        public void AddCourse(Course course)
        {
            if (TotalCourses < MaxCourseLimit)
            {
                bool alreadyTaken = false;
                for (int i = 0; i < MaxCourseLimit; i++)
                {
                    Course c = courses[i];
                    if (c != null)
                    {
                        if (c.CourseId == course.CourseId)
                        {
                            alreadyTaken = true;
                            break;
                        }
                    }
                }
                if (!alreadyTaken)
                {
                    bool canAdd = course.AddStudent(this);
                    if (canAdd)
                    {
                        for (int i = 0; i < MaxCourseLimit; i++)
                        {
                            Course c = courses[i];
                            if (c == null)
                            {
                                courses[i] = course;
                                TotalCourses++;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("This course is already taken.");
                }
            }
            else
            {
                Console.WriteLine("Can't take more than {0} courses.", MaxCourseLimit);
            }
        }

        public void DropCourse(Course course)
        {
            for (int i = 0; i < MaxCourseLimit; i++)
            {
                Course c = courses[i];
                if (c != null)
                {
                    if (c.CourseId == course.CourseId)
                    {
                        courses[i] = null;
                        TotalCourses--;
                        course.DropStudent(this);
                        break;
                    }
                }
            }
        }
        public void ShowCourses()
        {
            Console.WriteLine("\nAll Course Info of Student {0}: \n", name);
            foreach (Course c in courses)
            {
                if (c != null)
                {
                    c.ShowInfo();
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Student Department: " + dept.Name);
            Console.WriteLine("***************");
        }
    }
}
