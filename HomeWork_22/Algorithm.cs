using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_22
{
    public static class Algorithm
    {
        public static T MaxEx<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            using var e = source.GetEnumerator();

            T max = e.Current;
            while (e.MoveNext())
            {
                if (comparer.Compare(e.Current, max) > 0)
                    max = e.Current;
            }
            return max;
        }


        public static T MinEx<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            using var e = source.GetEnumerator();

            T min = e.Current;
            while (e.MoveNext())
            {
                if (comparer.Compare(e.Current, min) < 0)
                    min = e.Current;
            }
            return min;
        }

        public static List<T> TakeEx<T>(this IEnumerable<T> source, int count)
        {
            var result = new List<T>();
            int taken = 0;

            foreach (var item in source)
            {
                if (taken++ >= count) break;
                result.Add(item);
            }
            return result;
        }

        public static List<T> SkipEx<T>(this IEnumerable<T> source, int count)
        {

            var result = new List<T>();
            int skipped = 0;
            foreach (var item in source)
            {
                if (skipped < count) { skipped++; continue; }
                result.Add(item);
            }
            return result;
        }
    }
}
