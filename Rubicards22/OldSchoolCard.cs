using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class OldSchoolCard : ICard
    {
        public Color Color { get; }
        public Value Value { get; }

        public OldSchoolCard(Color color, Value value)
        {
            Color = color;
            Value = value;
        }
    }
}
