using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
           
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                var person = new Person(input[0], input[1], int.Parse(input[2]));
                /*if (person.CheckAge())
                {
                    people.Add(person);
                }
               */
                /*if (person.Age<=18)
                {
                    people.Add(person);
                }
                */
                people.Add(person);
            }
            //people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList().ForEach(p => Console.WriteLine(p.ToString()));
            people.OrderByDescending(x => x.Age).ToList().ForEach(x => Console.WriteLine(x.ToString()));
            people.Where(p => p.Age == 30).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
