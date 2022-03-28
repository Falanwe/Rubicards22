using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Rubicards22
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void TestListSorter()
        {
            var sorter = new ListSorter();
            var cards = new Card[]
            {
                new Card(Color.Cubs, Value.Ten),
                new Card(Color.Hearts, Value.Ace),
                new Card(Color.Diamonds, Value.Queen),
                new Card(Color.Hearts, Value.King),
                new Card(Color.Diamonds, Value.Queen)
            };

            var expected = new Card[]
            {
                new Card(Color.Cubs, Value.Ten),
                new Card(Color.Diamonds, Value.Queen),
                new Card(Color.Diamonds, Value.Queen),
                new Card(Color.Hearts, Value.King),
                new Card(Color.Hearts, Value.Ace),
                null
            };

            Assert.IsTrue(Enumerable.SequenceEqual(sorter.Sort(cards), expected));
        }
    }
}
