using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Course
    {
        public String Name { get; private set; }
        public String CourseId { get; private set; }
        private Student[] students;
        public int MaxStudentLimit { get; private set; }
        public int TotalStudents { get; private set; }
        public Course() { }
        public Course(String name, String courseId)
        {
            Name = name;
            CourseId = courseId;
            MaxStudentLimit = 30;
            TotalStudents = 0;
            students = new Student[MaxStudentLimit];
        }
        public bool AddStudent(Student student)
        {
            bool isAdded = false;
            if(TotalStudents < MaxStudentLimit){
                for(int i=0; i<MaxStudentLimit; i++){
                    Student s = students[i];
                    if(s==null){
                        students[i] = student;
                        TotalStudents++;
                        isAdded = true;
                        break;
                    }
                }
            }else{
                Console.WriteLine("Course Full, No Student can Register this Course.");
            }
            return isAdded;
        }
        public void DropStudent(Student student)
        {
            for (int i = 0; i < MaxStudentLimit; i++)
            {
                Student s = students[i];
                if (s != null)
                {
                    if(s.Id==student.Id){
                        students[i] = null;
                        TotalStudents--;
                        break;
                    }
                }
            }
        }
        public void ShowStudents()
        {
            Console.WriteLine("\nAll Students Info of Course {0}: \n", Name);
            foreach (Student s in students)
            {
                if (s != null)
                {
                    s.ShowInfo();
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine("Course Name: " + Name);
            Console.WriteLine("Course ID: " + CourseId);
            Console.WriteLine("Course Total Students: ({0}/{1})",TotalStudents,MaxStudentLimit);
            Console.WriteLine("***************");
        }
    }
}
