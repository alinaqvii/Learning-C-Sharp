using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student1 = new Student(1, "Ali", "Naqvi", 22);
            //var student2 = new Student(2, "Muhammad", "Ali", 21);
            //var student3 = new Student(3, "Nasir", "Hussain", 29);

            //var course = new Course("Programming with C#")
            //{
            //    Students = new Collection<Student> { student1, student2, student3 }
            //};


            //Console.WriteLine(course);
            List<StudentLINQ> students = new List<StudentLINQ>
            {
                new StudentLINQ {StdID = 1, StudentName = "Ali"},
                new StudentLINQ {StdID = 2, StudentName = "Hassan"},
                new StudentLINQ {StdID = 3, StudentName = "Hussain"},
                new StudentLINQ {StdID = 4, StudentName = "Abbas"},
            };


            List<CourseLINQ> course = new List<CourseLINQ>
            {
                new CourseLINQ { CourseID = "C001", Title = "OOPS"  },
                new CourseLINQ { CourseID = "C002", Title = "Data Structure"  },
                new CourseLINQ { CourseID = "C003", Title = "System Analysis"  },
                new CourseLINQ { CourseID = "C004", Title = "Database"  },
                new CourseLINQ { CourseID = "C005", Title = "Distributed Database"  },
            };

            List<StudentCourseLINQ> studentCourses = new List<StudentCourseLINQ>
            {
                new StudentCourseLINQ { StdID = 1, CourseID = "C0001" },
                new StudentCourseLINQ { StdID = 1, CourseID = "C0002" },
                new StudentCourseLINQ { StdID = 1, CourseID = "C0003" },
                new StudentCourseLINQ { StdID = 1, CourseID = "C0004" },
                new StudentCourseLINQ { StdID = 1, CourseID = "C0005" },

                new StudentCourseLINQ { StdID = 2, CourseID = "C0002" },
                new StudentCourseLINQ { StdID = 2, CourseID = "C0003" },

                new StudentCourseLINQ { StdID = 3, CourseID = "C0002" },
                new StudentCourseLINQ { StdID = 3, CourseID = "C0003" },
                new StudentCourseLINQ { StdID = 3, CourseID = "C0004" },
            };

            var innerJoin = from c in studentCourses
                            join s in students on c.StdID equals s.StdID
                            select new
                            {
                                StudentName = s.StudentName,
                                Enroll = c.CourseID
                            };

            foreach (var item in innerJoin)
            {
                System.Console.WriteLine($"Course ID: {item.Enroll}, Student Name: {item.StudentName}");
            }
        }
    }

    // public class Person
    // {
    //     private int ID { get; set; }
    //     private string Name { get; set; }
    //     private string FName { get; set; }
    //     private int PersonAge { get; set; }
    //     public Person(int id, string name, string fatherName, int age)
    //     {
    //         ID = id;
    //         Name = name;
    //         FName = fatherName;
    //         PersonAge = age;
    //     }
    // }

    // public class Student : Person
    // {
    //     public static int EnrolledCount;

    //     public Student(int id, string name, string fatherName, int age)
    //         : base(id, name, fatherName, age)
    //     {
    //         EnrolledCount++;
    //     }

    // }

    // public class Course
    // {
    //     public IEnumerable<Student> Students { get; set; }
    //     public string CourseName { get; set; }

    //     public CourseLINQ(string name)
    //     {
    //         CourseName = name;
    //         Students = new List<Student>();
    //     }

    //     public override string ToString()
    //     {
    //         return "The " + CourseName + " course contains " + Students.Count() + " student(s)";
    //     }
    // }
}