using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public interface ISorter
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>;
    }
}
