using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateApp
{

    /// <summary>
    /// A class to define a person
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        //Our delegate
        public delegate bool FilterDelegate(Person p);

        Dictionary<string, Person> persons = new Dictionary<string, Person>();

        static void Main(string[] args)
        {

            //Create 4 Person objects
            Person p1 = new Person() { Name = "John", Age = 41 };
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };

            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            //Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            Console.Read();
        }

        /// <summary>
        /// A method to filter out the people you need
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="filter">A filter</param>
        /// <returns>A filtered list</returns>
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }

            //** Non-delegate method======================================
            //if(title == "Children:")
            //{
            //    foreach (Person p in people)
            //    {
            //        if (p.Age < 18)
            //        {
            //            Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            //        }
            //    }
            //}else if (title == "Adults:")
            //{
            //    foreach (Person p in people)
            //    {
            //        if (p.Age >= 18)
            //        {
            //            Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            //        }
            //    }
            //}
            //else if (title == "Seniors:")
            //{
            //    foreach (Person p in people)
            //    {
            //        if (p.Age >= 65)
            //        {
            //            Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            //        }
            //    }
            //}
            //**======================================Non-delegate method
            Console.Write("\n\n");
        }

        //==========FILTERS===================
        static bool IsChild(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}