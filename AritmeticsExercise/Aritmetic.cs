using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticsExercise
{
    public static class Aritmetic
    {
        public static int Min(int x, int y)
        {
            return Math.Min(x, y);
        }
        public static int Max(int x,int y)
        {
           return Math.Max(x, y);
        }
        public static int Pow(int x)
        {
            return Convert.ToInt32(Math.Pow(x, 2));
        }
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = n; i >1; i--)
            {
                result*=i;
            }
            return result;
        }
        public static int Fibonacci(int n)
        {
            /* if (n <= 1)
             {
                 return n;
             }
             else
             {
                 return Fibonacci(n - 1) + Fibonacci(n - 2);
             }*/
            int a = 0;
            int b = 1;
            if (n == 0) return n;
            for (int i = 1; i < n; i++)
            {
                int c = a;
                a = b;
                b = c + b;
            }
            return a;

        }
        public static int Method1(int n,int m)
        {
            return Math.Max(Factorial(n), Fibonacci(m));
        }
        public static int NOD(int n, int m)//Най гоям общ делител -> алгоритъм на Евклид
        {
            while (m!=0)
            {
                int t = m;
                m = n %m;
                n = t;
            }
            return n;
        }
        public static int Lcm(int n,int m)//Най-малко общо кратно
        {
            return Math.Abs(n * m) / Aritmetic.NOD(n, m);
        }
    }
}
