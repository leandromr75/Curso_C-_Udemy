using System;
using System.Collections.Generic;

namespace HashSet_SortedSet_01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>() { 1, 3, 5, 7, 9 };
            HashSet<int> b = new HashSet<int>() { 0, 2, 5, 6, 8 };

            HashSet<int> c = new HashSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            Console.WriteLine();

            SortedSet<int> x = new SortedSet<int>() { 1, 3, 5, 7, 9 };
            SortedSet<int> y = new SortedSet<int>() { 0, 2, 5, 6, 8 };

            SortedSet<int> z = new SortedSet<int>(x);
            z.UnionWith(y);

            PrintCollection(z);

            static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach (T obj in collection)
                {
                    Console.Write(obj + " ");
                }
            }
        }
    }
}
