using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class Dealer
    {
        private readonly Random _random = new Random();

        //generate a random card, with equal probability of all cards
        public Card GetRandomCard()
        {            
            Color color = (Color)_random.Next(0, Enum.GetValues(typeof(Color)).Length);
            Value value = (Value)_random.Next(0, Enum.GetValues(typeof(Value)).Length);
            return new Card(color, value);
        }
    }
}
