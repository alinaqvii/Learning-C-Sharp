using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] marks = {23, 24, 34, 45, 56};

            // //Without LINQ
            // List<int> res = new List<int>();
            // foreach (var k in marks)
            // {
            //     if (k % 2 == 0)
            //     {
            //         res.Add(k);
            //     }
            // }
            // System.Console.WriteLine("Without LINQ");

            // foreach (var j in res)
            // {
            //     System.Console.WriteLine(j + " is an even number");
            // }
            
            // //With LINQ
            // IEnumerable<int> result = from p1 in marks
            //                           where p1 % 2 == 0
            //                           select p1;

            // // marks[1] = 33;
            // System.Console.WriteLine("With LINQ");
            // foreach (var data in result)
            // {
            //     Console.WriteLine(data + " is an even number");
            // }
            // // Console.WriteLine("Hello World!");

            int[] data = {12, 34, 35, 37, 119, 110};
            // || && operator

            IEnumerable<int> res = from p in data
                                   where p % 2 == 0 || p > 100
                                   select p;

            foreach (var k in res)
            {
                System.Console.WriteLine(k);
            }

        }
    }
}
