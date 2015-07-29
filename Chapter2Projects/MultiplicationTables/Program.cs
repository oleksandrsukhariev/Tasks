using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTables
{
    internal sealed class Program
    {

        private static void Main(string[] args)
        {
            TableWithFor();
            TableWithDoWhile();
            TableWithWhile();
            TableWithForeach();

            Console.ReadLine();
        }

        #region MethodsWithLoops


        static void TableWithFor()
        {
            Console.WriteLine("With FOR loop...");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0}\t", i * j);
                    Console.ResetColor();
                }

            }
            Console.WriteLine();
        }

        static void TableWithDoWhile()
        {
            Console.WriteLine("With DO-WHILE loop...");
            int i = 1;
            int j = 1;
            int k;
            do
            {
                k = j;
                do
                {
                    if (k == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0}\t", i * k);
                    Console.ResetColor();
                    k++;
                }
                while (k <= 10);
                i++;
            }
            while (i <= 10);
            Console.WriteLine();
        }

        static void TableWithWhile()
        {
            Console.WriteLine("With WHILE loop...");
            int i = 1;
            int j = 1;
            int k;

            while (i <= 10)
            {
                k = j;
                while (k <= 10)
                {
                    if (k == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0}\t", i * k);
                    Console.ResetColor();
                    k++;
                }
                i++;
            }
            Console.WriteLine();
        }

        static void TableWithForeach()
        {
            Console.WriteLine("With FOREACH loop...");
            var k = FillRange(1, 10);
            foreach (int i in k)
            {
                foreach (int y in k)
                {
                    if (i == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0}\t", i * y);
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Set variable to IEnumerable with range
        /// </summary>
        /// <param name="of"></param>
        /// <param name="until"></param>
        /// <returns></returns>
        static IEnumerable<int> FillRange(int of, int until)
        {
            while (of <= until) yield return of++;
        }
        #endregion
    }
}
