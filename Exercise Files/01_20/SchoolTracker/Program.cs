using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("How many students in Class?");
            // var studentCount = int.Parse(Console.ReadLine());

            // var studentNames = new string[studentCount];
            // var studentGrades = new int[studentCount];

                var studentNames = new List<string>();
                var studentGrades = new List<int>();
 
                var adding = true;

            while (adding)
            {
                Console.WriteLine("Student Name: ");
                studentNames.Add(Console.ReadLine());
                
                Console.WriteLine("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != y)
                    adding = false;                    
                }
            }
            
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
