using System;
using System.Runtime.CompilerServices;

namespace NiGames.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Try to get value from array by index.
        /// </summary>
        public static bool TryGetValue<T>(this T[] array, int index, out T value)
        {
            if (index < array.Length && index >= 0)
            {
                value = array[index];
                return true;
            }
            
            value = default;
            return false;
        }
        
        /// <summary>
        /// Abbreviation for <c>Array.Copy</c>. Returns a copy of the array.
        /// </summary>
        public static T[] Copy<T>(this T[] array)
        {
            var newArray = Array.Empty<T>();
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }
        
        /// <summary>
        /// Abbreviation for <c>Array.Sort</c>.
        /// </summary>
        [MethodImpl(256)]
        public static void Sort<T>(this T[] array)
        {
            Array.Sort(array);
        }
        
        /// <summary>
        /// Abbreviation for <c>Array.IndexOf</c>.
        /// </summary>
        [MethodImpl(256)]
        public static int IndexOf<T>(this T[] array, T element)
        {
            return Array.IndexOf(array, element);
        }
        
        /// <summary>
        /// Abbreviation for <c>Array.FindIndex</c>.
        /// </summary>
        [MethodImpl(256)]
        public static int FindIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindIndex(array, match);
        }
    }
}