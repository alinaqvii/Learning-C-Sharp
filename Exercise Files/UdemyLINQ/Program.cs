using System;
using System.Linq;
using System.Collections.Generic;

namespace UdemyLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 5, 6, 7, 9, 3, 5, 3, 2, 4, 6, 2, 9, 7 };
            // string sentence = "I love Horses";
            // string[] horseNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Tony", "Loki" };

            // var getTheNumbers = from number in numbers
            //                     where number <= 5
            //                     orderby number descending
            //                     select number;

            // var horseWithA = from horse in horseNames
            //                  where horse.Contains("a")
            //                  where horse.Length < 5
            //                  select horse;

            // System.Console.WriteLine(string.Join(", ", horseWithA));

            // System.Console.WriteLine(string.Join(", ", getTheNumbers));

            //LINQ Queries with Objects

            List<Person> people = new List<Person>()
            {
                new Person("Tod", 180, 70, Gender.Male),
                new Person("John", 170, 88, Gender.Male),
                new Person("Anna", 150, 48, Gender.Female),
                new Person("Kyle", 164, 77, Gender.Male),
                new Person("Anna", 164, 77, Gender.Male),
                new Person("Maria", 160, 55, Gender.Female),
                new Person("John", 160, 55, Gender.Female),
            }

            var fourCharPeople = from p in people
                                where (p.Name.Length == 4)
                                orderby p.Weight
                                select p;

            foreach (var item in fourCharPeople)
            {
                // System.Console.WriteLine(item.Name);
                System.Console.WriteLine(value: $"Name: {item.Name}, Weight: {item.Weight}");
            }
        }
    }

    internal class Person
    {
        private string name;
        private int height;
        private int weight;
        private Gender gender;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public Gender Gender1;

        public Person(string name, int height, int weight, Gender gender)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Gender1 = gender;
        }

        internal enum Gender
        {
            Male,
            Female
        }
}
}
