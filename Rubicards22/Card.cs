using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public record Card(Color Color, Value Value) : ICard, IComparable<Card>
    {
        private int InnerValue => (int)Value * 4 + (int)Color;

        public int CompareTo(Card other)
        {
            //AgumentNullException.ThrowIfNull(other);
            if(other == null)
            {
                throw new ArgumentNullException();
            }

            var valueComparison = Value.CompareTo(other.Value);
            if(valueComparison != 0)
            {
                return valueComparison;
            }
            else
            {
                return Color.CompareTo(other.Color);
            }
        }

        public int OtherCompareTo(Card other) => InnerValue - other.InnerValue;
    }
}
