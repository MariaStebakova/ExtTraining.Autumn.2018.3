using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator<T>
    {
        public static IEnumerable<T> Generate(T first, T second, int n, Func<T,T,T> func)
        {
            return GenerateInner();

            IEnumerable<T> GenerateInner()
            {
                yield return first;
                yield return second;

                for (int i = 2; i < n; i++)
                {
                    T next = func(first, second);
                    yield return next;

                    first = second;
                    second = next;
                }
            }
        }
    }
}
