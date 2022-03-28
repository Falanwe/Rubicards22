using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class FusionSorter : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            if (!source.Skip(1).Any())
            {
                foreach(var e in source)
                {
                    yield return e;
                    yield break;
                }
            }

            var split = source.Select((e, index) => (e, index)).GroupBy(pair => pair.index % 2, pair => pair.e);
            var left = split.First();
            var right = split.Last();

            var leftEnumerator = Sort(left).GetEnumerator();
            var rightEnumerator = Sort(right).GetEnumerator();

            var leftHasElements = leftEnumerator.MoveNext();
            var rightHasElements = rightEnumerator.MoveNext();

            while (leftHasElements && rightHasElements)
            {
                if (leftEnumerator.Current.CompareTo(rightEnumerator.Current) <= 0)
                {
                    yield return leftEnumerator.Current;
                    leftHasElements = leftEnumerator.MoveNext();
                }
                else
                {
                    yield return rightEnumerator.Current;
                    rightHasElements = rightEnumerator.MoveNext();
                }
            }

            while (leftHasElements)
            {
                yield return leftEnumerator.Current;
                leftHasElements = leftEnumerator.MoveNext();
            }

            while (rightHasElements)
            {
                yield return rightEnumerator.Current;
                rightHasElements = rightEnumerator.MoveNext();
            }
        }
    }
}
