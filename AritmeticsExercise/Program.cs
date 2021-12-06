using System;

namespace AritmeticsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Console.WriteLine(Aritmetic.Factorial(0));
            // Console.WriteLine(Aritmetic.Fibonacci(1));//0,1,1,2,3,5
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(Aritmetic.Factorial(n));
            Console.WriteLine(Aritmetic.Fibonacci(m));
            Console.WriteLine(Aritmetic.Method1(n, m));
            Console.WriteLine(Aritmetic.NOD(n, m));
            Console.WriteLine(Aritmetic.Lcm(n,m));

        }
    }
}
