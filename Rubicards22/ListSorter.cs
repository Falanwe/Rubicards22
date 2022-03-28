using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class ListSorter : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            var result = new List<T>(source);
            result.Sort();
            return result;
        }
    }
}
