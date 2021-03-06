#if AFTER_NETSTANDARD1_3 || AFTER_NET45
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq
{
    public static class SortedListExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(this IDictionary<TKey, TValue> source)
            => new SortedList<TKey, TValue>(source);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(this IDictionary<TKey, TValue> source, IComparer<TKey> comparer)
            => new SortedList<TKey, TValue>(source, comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(this IDictionary<TKey, TValue> source, Comparison<TKey> comparison)
            => source.ToSortedList(Comparer<TKey>.Create(comparison));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
            => new SortedList<TKey, TValue>() { source };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IComparer<TKey> comparer)
            => new SortedList<TKey, TValue>(comparer) { source };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, Comparison<TKey> comparison)
            => source.ToSortedList(Comparer<TKey>.Create(comparison));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
            => source.SelectKeyValuePair(keySelector).ToSortedList();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, IComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector).ToSortedList(comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, Comparison<TKey> comparison)
            => source.SelectKeyValuePair(keySelector).ToSortedList(comparison);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedList();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, IComparer<TKey> comparer)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedList(comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SortedList<TKey, TValue> ToSortedList<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector, Comparison<TKey> comparison)
            => source.SelectKeyValuePair(keySelector, valueSelector).ToSortedList(comparison);
    }
}
#endif
