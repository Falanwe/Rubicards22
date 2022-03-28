using System;

namespace Rubicards22
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new Dealer();

            var randomCard = dealer.GetRandomCard();

            Console.WriteLine($"j'ai tiré la carte {randomCard}");
        }
    }
}
