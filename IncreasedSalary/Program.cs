﻿using System;
using System.Collections.Generic;

namespace IncreasedSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreasedSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            Console.WriteLine(Person.Count);
        }
    }
}
