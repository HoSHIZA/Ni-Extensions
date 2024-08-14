using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace NiGames.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Adds a value if the list does not contain it.
        /// </summary>
        [MethodImpl(256)]
        public static void AddIfNotContains<T>(this List<T> list, T element)
        {
            if (list.Contains(element)) return;
            
            list.Add(element);
        }
        
        /// <summary>
        /// Adds a value if the list does not contain it.
        /// </summary>
        [MethodImpl(256)]
        public static void AddIfNotExists<T>(this List<T> list, T element, Predicate<T> match)
        {
            if (list.Exists(match)) return;
            
            list.Add(element);
        }
    }
}