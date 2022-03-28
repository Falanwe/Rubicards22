using System;
using System.Collections.Generic;
using System.Linq;

namespace Rubicards22
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new SorterTests();

            var sorter = new ListSorter();
            if(tests.TestSorter(sorter, out var count))
            {
                Console.WriteLine($"{nameof(ListSorter)} succeeded in {count} comparisons");
            }
        }
    }
}
