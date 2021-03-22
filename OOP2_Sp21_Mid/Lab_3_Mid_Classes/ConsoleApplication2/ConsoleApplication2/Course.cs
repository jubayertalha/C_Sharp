using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course()
        {
            Console.WriteLine("\n...Empty Course Object Created...\n");
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
        }

        public string CourseName
        {
            set
            {
                courseName = value;
            }
            get
            {
                return courseName;
            }
        }

        public string CourseCode
        {
            set
            {
                courseCode = value;
            }
            get
            {
                return courseCode;
            }
        }

        public int CourseCredit
        {
            set
            {
                courseCredit = value;
            }
            get
            {
                return courseCredit;
            }
        }
    }
}
