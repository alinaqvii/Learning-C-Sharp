using System;

namespace Arr
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
        }
    }

    public class Point
    {
        public int X,
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }
    public class Calculator
    {
        public int Add(params int[] numbers){};
    }    

    var results = Calculator.Add(new  int[]{1, 2, 3, 4}){};
    //by using Params Modifier
    var results = Calculator.Add(1, 2, 3, 4){};

    // The Ref Modifier

    public class Weirdo
    {
        public void doWeirdoThing(ref int a)
        {
            a +=2;
        }

        var a = 1;

        Weirdo.doWeirdoThing(ref a);
    }
}
