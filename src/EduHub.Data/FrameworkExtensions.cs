using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHub.Data
{
    internal static class FrameworkExtensions
    {
        internal static NullDictionary<TKey, TSource> ToNullDictionary<TSource, TKey>(this IEnumerable<TSource> Source, Func<TSource, TKey> KeySelector)
        {
            var dictionary = new NullDictionary<TKey, TSource>();
            foreach (var item in Source)
            {
                dictionary.Add(KeySelector(item), item);
            }
            return dictionary;
        }

        internal static NullDictionary<TKey, IReadOnlyList<TSource>> ToGroupedNullDictionary<TSource, TKey>(this IEnumerable<TSource> Source, Func<TSource, TKey> KeySelector)
        {
            var dictionary = new NullDictionary<TKey, IReadOnlyList<TSource>>();
            foreach (var item in Source.GroupBy(KeySelector))
            {
                dictionary.Add(item.Key, item.ToList().AsReadOnly());
            }
            return dictionary;
        }

        internal static Dictionary<TKey, IReadOnlyList<TSource>> ToGroupedDictionary<TSource, TKey>(this IEnumerable<TSource> Source, Func<TSource, TKey> KeySelector)
        {
            return Source
                .GroupBy(KeySelector)
                .ToDictionary(
                    g => g.Key,
                    g => (IReadOnlyList<TSource>)g.ToList().AsReadOnly());
        }

        internal static Dictionary<TKey, int> ToIndexDictionary<TSource, TKey>(this IList<TSource> Source, Func<TSource, TKey> KeySelector)
        {
            Dictionary<TKey, int> dictionary = new Dictionary<TKey, int>(Source.Count);

            for (int i = 0; i < Source.Count; i++)
            {
                dictionary.Add(KeySelector(Source[i]), i);
            }

            return dictionary;
        }

        internal static NullDictionary<TKey, int> ToIndexNullDictionary<TSource, TKey>(this IList<TSource> Source, Func<TSource, TKey> KeySelector)
        {
            NullDictionary<TKey, int> dictionary = new NullDictionary<TKey, int>(Source.Count);

            for (int i = 0; i < Source.Count; i++)
            {
                dictionary.Add(KeySelector(Source[i]), i);
            }

            return dictionary;
        }

        internal static IEnumerable<T> Remove<T>(this IList<T> Source, HashSet<int> Indexes)
        {
            int[] removeIndexes = new int[Indexes.Count];
            Indexes.CopyTo(removeIndexes);
            Array.Sort(removeIndexes);

            int index = 0;

            foreach (var removeNext in removeIndexes)
            {
                while (index < removeNext)
                {
                    yield return Source[index];
                    index++;
                }
                index++;
            }

            for (; index < Source.Count; index++)
            {
                yield return Source[index];
            }
        }
    }
}
