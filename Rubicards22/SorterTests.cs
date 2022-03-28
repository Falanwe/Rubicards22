using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rubicards22
{
    public class SorterTests
    {
        private static readonly List<Card> _cards = new List<Card>();
        private static readonly List<Card> _sortedCards = new List<Card>();
        static SorterTests()
        {
            var dealer = new Dealer();
            for(var i = 0; i<1000; i++)
            {
                _cards.Add(dealer.GetRandomCard());
            }

            _sortedCards = _cards.OrderBy(c => c).ToList();
        }

        public bool TestSorter(ISorter sorter, out int count)
        {
            Card.ResetComparisonCount();
            var sorted = sorter.Sort(_cards);

            count = Card.ComparisonCount;
            return Enumerable.SequenceEqual(sorted, _sortedCards);
        }
    }
}
