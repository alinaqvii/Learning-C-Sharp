using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(1, "Ali", "Naqvi", 22);
            var student2 = new Student(2, "Muhammad", "Ali", 21);
            var student3 = new Student(3, "Nasir", "Hussain", 29);

            var course = new Course("Programming with C#")
            {
                Students = new Collection<Student> { student1, student2, student3 }
            };


            Console.WriteLine(course);
        }
    }

    public class Person
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string FName { get; set; }
        private int PersonAge { get; set; }
        public Person(int id, string name, string fatherName, int age)
        {
            ID = id;
            Name = name; 
            FName = fatherName;
            PersonAge = age;
        }
    }

    public class Student : Person
    {
        public static int EnrolledCount;

        public Student(int id, string name, string fatherName, int age)
            : base(id, name, fatherName, age)
        {
            EnrolledCount++;
        }
       
    }

    public class Course
    {
        public IEnumerable<Student> Students { get; set; }
        public string CourseName { get; set; }

        public Course(string name)
        {
            CourseName = name;
            Students = new List<Student>();
        }

        public override string ToString()
        {
            return "The " + CourseName + " course contains " + Students.Count() + " student(s)";
        }
    }
}




