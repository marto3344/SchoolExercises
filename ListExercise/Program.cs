using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                //string name = Console.ReadLine();
                //names.Add(name);

                names.Add(Console.ReadLine());
            }
            
            //Console.WriteLine(string.Join("\n",names.OrderBy(x=>x)));
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
           
        }
    }
}
