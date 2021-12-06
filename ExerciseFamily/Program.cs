using System;
using System.Collections.Generic;
using System.Linq;
namespace ExerciseFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            var family1 = new Family();
            var parent1 = new Person(input[0], int.Parse(input[1]));
            input = Console.ReadLine().Split(" ").ToList();
            var parent2 = new Person(input[0], int.Parse(input[1]));
            input = Console.ReadLine().Split(" ").ToList();
            var kid1 = new Person(input[0], int.Parse(input[1]));
            input = Console.ReadLine().Split(" ").ToList();
            var kid2 = new Person(input[0], int.Parse(input[1]));
            family1.AddParent(parent1);
            family1.AddParent(parent2);
            family1.AddKid(kid1);
            family1.AddKid(kid2);          
            Console.WriteLine(family1.ToString());

        }
        
    }
}
