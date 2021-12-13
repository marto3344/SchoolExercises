using System;
using System.Collections.Generic;
using System.Linq;
namespace CustomMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial {CustomMath.Factorial(n)}");
            Console.WriteLine("Please enter n & k:");
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine($"Combinations: {CustomMath.Combination(input[0],input[1])}");
           
        }
    }
}
