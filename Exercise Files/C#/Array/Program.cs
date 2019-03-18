using System;

namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int[] another = new int[3];
            Array.Copy(numbers, another,3);

            Console.WriteLine("Effects of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort
            Array.Sort(numbers);

            Console.WriteLine("Effects of Sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse
            Array.Reverse(numbers);

            Console.WriteLine("Effects of Reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
