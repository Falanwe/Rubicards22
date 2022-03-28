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

            ISorter sorter = new ListSorter();
            if(tests.TestSorter(sorter, out var count))
            {
                Console.WriteLine($"{nameof(ListSorter)} succeeded in {count} comparisons");
            }
            else
            {
                Console.WriteLine($"{nameof(ListSorter)} failed");
            }

            sorter = new InsertSorter();
            if (tests.TestSorter(sorter, out count))
            {
                Console.WriteLine($"{nameof(InsertSorter)} succeeded in {count} comparisons");
            }
            else
            {
                Console.WriteLine($"{nameof(InsertSorter)} failed");
            }

            //var hand = new List<Card>();
            //var dealer = new Dealer();
            //for (var i = 0; i < 5; i++)
            //{
            //    hand.Add(dealer.GetRandomCard());
            //}
            //foreach (var card in sorter.Sort(hand))
            //{
            //    Console.WriteLine(card);
            //}


            sorter = new FusionSorter();
            if (tests.TestSorter(sorter, out count))
            {
                Console.WriteLine($"{nameof(FusionSorter)} succeeded in {count} comparisons");
            }
            else
            {
                Console.WriteLine($"{nameof(FusionSorter)} failed");
            }
        }
    }
}
