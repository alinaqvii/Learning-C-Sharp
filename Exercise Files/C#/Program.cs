using System;

namespace C_
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class Person
    {
        public string firstName;
        public string lastName;
        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }

    class Enums
    {
        public enum shipping
        {
            RegularAirMail = 1,
            RegiteredAirMail = 2,
            Express = 3
        }
        // var enume = shipping.Express;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 1;
            // var b = 22;
            // var c = 3;
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(a + b * c);
            // Console.WriteLine(a == b);
            // Console.WriteLine(b > a && b > c);

            // var ali = new Person();

            // ali.firstName = "Ali";
            // ali.lastName = "Naqvi";

            // ali.Introduce();
            
            // var calc = new Calculator();
            // var result = calc.Add(23, 22);

            // Console.WriteLine(result);

            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // for (int i = 10; i >= 1; i--)
            // {
            //     if (i%2 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // int val = 5;

            // for (int i = 1; i <= val; i++)
            // {
                               
            //     for (int k = 1; k <= i; k++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine("");
            // }

            // Console.WriteLine("-----------------");

            // for (int i = 1; i <= val; i++)
            // {
                               
            //     for (int k = 5; k >= i; k--)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine("");
            // }

            int[] numbers = new int[]{3, 7, 9, 2, 5, 15};

            //Length of Array
            Console.WriteLine("Length is :" + numbers.Length);

            //Index of Array
            var index = Array.IndexOf(numbers, 5);
            Console.WriteLine("Index of 5 is:" + index);

            //Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}
