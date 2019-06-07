using System;
using System.Collections;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        // Ex 4
        private static IEnumerable<E> GetBefore<E>(IEnumerable <E> stuff, E x)
            where E : IComparable<E>
        {
            foreach (E y in stuff)
            {
                if (y.CompareTo(x) < 0) yield return y;
            }
        }

        static void Main(string[] args)
        {
            int[] myInts = {2, 3, 5, 7, 8, -10, -6 };
            foreach (int i in GetBefore<int>(myInts, 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}
