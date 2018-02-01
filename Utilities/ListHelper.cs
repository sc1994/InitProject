﻿using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class ListHelper
    {
        /// <summary>
        /// 克隆完全独立的副本
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="that"></param>
        /// <returns></returns>
        public static List<T> Clone<T>(this IList<T> that)
        {
            var result = new List<T>();
            foreach (var item in that)
            {
                result.Add(item.ToJson().JsonToObject<T>());
            }
            return result;
        }

        /// <summary>
        /// 去重复
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IList<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            foreach (var element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
