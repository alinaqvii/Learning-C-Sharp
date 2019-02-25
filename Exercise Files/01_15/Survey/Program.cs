using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if(name == ""){
                
                name = WriteTypeAgain();
            }

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            if(age == ""){
                
                age = WriteTypeAgain();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            if(month == ""){
                
                month = WriteTypeAgain();
            }

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if(month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if(month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
        }
        static string WriteTypeAgain(){
             Console.WriteLine("You didnt type anything, please try again.");
             return Console.ReadLine();
        }
    }
}

