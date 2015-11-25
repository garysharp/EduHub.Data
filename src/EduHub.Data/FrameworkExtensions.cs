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
    }
}
