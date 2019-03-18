using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>(){2, 4, 6, 7, 8};
            numbers.Add(1);
            numbers.AddRange(new int[3]{7, 9, 4});

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            

            System.Console.WriteLine(   );
            System.Console.WriteLine("Index of 7: " + numbers.IndexOf(7));
            System.Console.WriteLine("Last Index of 7: " + numbers.LastIndexOf(7));
            System.Console.WriteLine("COunt of Numbers: " + numbers.Count);


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 7)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            // foreach (var number in numbers)
            // {
                
            // }
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Clear();
        }
    }
}
