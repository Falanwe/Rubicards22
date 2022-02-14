using System;

namespace Rubicards22
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(Color.Diamonds, Value.Ace);

            var spadesCard = card with { Color = Color.Spades };
        }
    }
}
