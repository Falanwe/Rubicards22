using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class BubbleSorter : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            List<T> tri = new List<T>(source);

            bool isValid = false;
            for (int i = tri.Count; i > 1; i--)
            {
                isValid = true;
                for (int j = 0; j < i - 1; j++)
                {
                    if (tri[j + 1].CompareTo(tri[j]) < 0)
                    {
                        T aTrier = tri[j + 1];
                        tri[j + 1] = tri[j];
                        tri[j] = aTrier;
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    return tri;
                }
            }

            return tri;
        }
    }
}
