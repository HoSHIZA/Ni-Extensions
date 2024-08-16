using System;
using System.Collections.Generic;
using System.Linq;

namespace NiGames.Extensions
{
    public static class EnumerableExtensions
    {
        #region IEnumerable

        /// <summary>
        /// Performs an action for each item in the collection.
        /// </summary>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            var arr = @this.ToArray();
            foreach (var item in arr)
            {
                action?.Invoke(item);
            }
            return arr;
        }

        #endregion
    }
}