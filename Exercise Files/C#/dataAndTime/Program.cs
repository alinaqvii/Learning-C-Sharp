using System;

namespace dataAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2019, 1, 1);
            var now = DateTime.Now; 
            var Today = DateTime.Today;

            Console.WriteLine("Hour: "+ now.Hour);
            Console.WriteLine("Minute: "+ now.Minute);
            System.Console.WriteLine("Time: " + now.Hour + ":" + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.ToString("yyyy-mm-dd HH:MM"));
            
        }
    }
}
