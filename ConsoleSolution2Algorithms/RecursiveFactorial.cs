using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class RecursiveFactorial
    {
        public static int RecursiveFactorialBlabla(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return n * RecursiveFactorialBlabla(n - 1);
        }

        public static int IterativeFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
