using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class QuickSorter : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            if(!source.Any())
            {
                return source;
            }

            var pivot = source.First();

            var split = source.Skip(1).GroupBy(e => Math.Sign(e.CompareTo(pivot)));

            var lesser = split.FirstOrDefault(g => g.Key == -1) ?? Enumerable.Empty<T>();
            var equals = split.FirstOrDefault(g => g.Key == 0) ?? Enumerable.Empty<T>();
            var greater = split.FirstOrDefault(g => g.Key == 1) ?? Enumerable.Empty<T>();

            return Sort(lesser).Concat(equals).Concat(Enumerable.Repeat(pivot, 1)).Concat(Sort(greater));
        }
    }
}
