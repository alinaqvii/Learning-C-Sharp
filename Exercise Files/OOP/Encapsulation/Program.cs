using OOPExamples;
using System;

class Program
{
    static void Main(string[] args)
    {

        var comp = new Computer("Generic Computer");
        
        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);

        Console.Read();

    }
}

