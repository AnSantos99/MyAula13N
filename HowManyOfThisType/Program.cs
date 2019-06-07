using System;
using System.Collections;

namespace HowManyOfThisType
{
    class Program
    {
        // Exercicio 3
        private static int MyNumbers<T>(IEnumerable numbers)
        {
            int total = 0;

            foreach (object i in numbers)
            {
                if (i is T) total++;
            }
            return total;  
        }

        static void Main(string[] args)
        {
            object[] myNumber = {"Ola", 3, 2.4f, "Dia", 10.2, 7, 12 };

            Console.WriteLine($"N strings: {MyNumbers<string>(myNumber)}");
            Console.WriteLine($"N ints: {MyNumbers<int>(myNumber)}");
        }
    }
}
