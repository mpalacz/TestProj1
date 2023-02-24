using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj1
{
    internal class MathOperations
    {
        public static double addition(double a, double b)
        {
            return a + b;
        }
        public static double subtractition(double a, double b)
        {
            return a - b;
        }
        public static double multiplication(double a, double b)
        {
            return a * b;
        }
        public static double division(double a, double b)
        {
            if (a == 0 || b == 0)
                return 0;
            return a / b;
        }
    }
}
