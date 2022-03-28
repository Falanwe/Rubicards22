using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicards22
{
    public class InsertSorter : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            var result = new List<T>();

            foreach (T card in source)
            {
                for (int i = 0; i <= result.Count; i++)
                {
                    if (i == result.Count)
                    {
                        result.Add(card);
                        break;
                    }
                    else
                    {
                        if (card.CompareTo(result[i]) <= 0)
                        {
                            result.Insert(i, card);
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
