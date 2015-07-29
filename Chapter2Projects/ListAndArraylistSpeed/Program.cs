using System;
using System.Collections;
using System.Collections.Generic;

namespace ListAndArraylistSpeed
{
    internal sealed class Program
    {
        public static void Main()
        {
            IntWatch();
            StringWatch();
            IntSortWatch();
            StringSortWatch();
            Console.ReadLine();
        }

        private static void IntWatch()
        {
            const int count = 2000000;
            using (new Watcher("List<int>"))
            {
                var l = new List<int>();
                for (var n = 0; n < count; n++)
                {
                    l.Add(n);
                }
            }
            using (new Watcher("ArrayList of int"))
            {
                var a = new ArrayList();
                for (var n = 0; n < count; n++)
                {
                    a.Add(n);
                }
            }
        }

        private static void StringWatch()
        {
            const int count = 2000000;
            using (new Watcher("List<string>"))
            {
                var l = new List<string>();
                for (var n = 0; n < count; n++)
                {
                    l.Add("X");
                }
            }
            using (new Watcher("ArrayList of string"))
            {
                var a = new ArrayList();
                for (var n = 0; n < count; n++)
                {
                    a.Add("X");
                }
            }
        }

        private static void IntSortWatch()
        {
            const int count = 2000;

            var l = new List<int>();
            for (var n = 0; n < count; n++)
            {
                l.Add(n);
            }
            using (new Watcher("List<int> sort"))
            {
                l.Sort();
            }

            var a = new ArrayList();
            for (var n = 0; n < count; n++)
            {
                a.Add(n);
            }
            using (new Watcher("ArrayList of int sort"))
            {
                a.Sort();
            }
        }

        private static void StringSortWatch()
        {
            const int count = 2000;

            var l = new List<string>();
            for (var n = 0; n < count; n++)
            {
                l.Add("X");
            }
            using (new Watcher("List<string> sort"))
            {
                l.Sort();
            }

            var a = new ArrayList();
            for (var n = 0; n < count; n++)
            {
                a.Add("X");
            }
            using (new Watcher("ArrayList of string sort"))
            {
                a.Sort();
            }
        }
    }
}

