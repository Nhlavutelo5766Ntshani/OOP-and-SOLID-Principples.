using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDryPrinciple
{
    class Program
    {
      
        static void Main(string[] args)
        {
            PrintPersonsInformation();
            Console.ReadLine();
        }
        private static void PrintPersonsInformation()
        {
            var persons = new List<Person>()
            {
                new Person("Milos Protic", 30),
                new Person("John Doe", 29),
                new Person("Jack Fish", 45)

            };
            persons.ForEach(
                person => person.PrintInformation()
                );
        }
         
    }
    public static class Constants
    {
        public const string CITY = "Novi Sad";
        public const string STATE = "Serbia";
    }
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string State => Constants.STATE;
        public string City => Constants.CITY;
        public int Age { get; set; }
        public string Name { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine($"{Name} lives in {City} ," + $"{State} and he is{Age} years old!");
        }

    }
}
