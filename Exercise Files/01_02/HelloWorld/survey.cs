namespace HelloWorld
{
    public class survey
    {
        Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();
            
            Console.WriteLine("What month you are born in?");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("The month you are born in is: {0}", month);
        
    }
}