using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ali Naqvi ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("UpperCase: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: " + lastName);

            //Using Split Method
            var names = fullName.Split(' ');
            System.Console.WriteLine("First Name: " + names[0]);
            System.Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine(fullName.Replace("Ali", "ALI"));

            //To check whitespaces

            //if (String.IsNullOrWhiteSpace(" "))

            // String to Int

            var str = "25";
            var age = Convert.ToInt32(str);
            System.Console.WriteLine(age);

            //Int to String

            float x = 25.95f;
            System.Console.WriteLine(x.ToString("C")); 

        }
    }
}
