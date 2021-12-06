using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMathClass
{
    public static class CustomMath
    {
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
        public static double Combination(int n,int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n-k));
        }
    }
}
