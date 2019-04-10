using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        enum Title
        {
            Maths,
            Chemistry,
            Physics,
            Computer
        }
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>
            {
                new Student {ID = 1, Name = "Ali", FName = "Muhammad", DOB = 02011990},
                new Student {ID = 2, Name = "Hussain", FName = "Ali", DOB = 02011989},
                new Student {ID = 3, Name = "Salman", FName = "Ahmed", DOB = 12121987}
            };

            List<Course> course = new List<Course>
            {
                new Course{CourseID = 1, Title = "Maths"},
                new Course{CourseID = 2, Title = "Computer"},
                new Course{CourseID = 3, Title = "Physics"}
            };
        }
    }

    class Student
    {
        public int ID;
        public string Name;
        public string FName;
        public int DOB;

    }

    class Course
    {
        public int CourseID;
        public string Title;

    }
    

    // class StudentCourse : Student
    // {
    //     public int StudentID = ID;

    // }
}
