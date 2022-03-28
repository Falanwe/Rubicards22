using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rubicards22
{
    public record Card(Color Color, Value Value) : ICard, IComparable<Card>
    {
        private static int _comparisonCount;
        public static void ResetComparisonCount() => _comparisonCount = 0;

        private int InnerValue => (int)Value * 4 + (int)Color;

        public int CompareTo(Card other)
        {
            Interlocked.Increment(ref _comparisonCount);

            //AgumentNullException.ThrowIfNull(other);
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            var valueComparison = Value.CompareTo(other.Value);
            if (valueComparison != 0)
            {
                return valueComparison;
            }
            else
            {
                return Color.CompareTo(other.Color);
            }
        }

        public int OtherCompareTo(Card other) => InnerValue - other.InnerValue;

        public override string ToString() => $"{Value} of {Color}";
    }
}
