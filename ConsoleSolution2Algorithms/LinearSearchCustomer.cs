using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class LinearSearchCustomer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }


        private static bool Existsdddd(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private static int IndexOf(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

    }

    internal class CustomersComparer : IEqualityComparer<LinearSearchCustomer>
    {
        public bool Equals([AllowNull] LinearSearchCustomer x, [AllowNull] LinearSearchCustomer y)
        {
            return x.Age == y.Age && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] LinearSearchCustomer obj)
        {
            return obj.GetHashCode();
        }
    }


}
