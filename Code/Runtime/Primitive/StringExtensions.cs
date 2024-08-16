using System;

namespace NiGames.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Fast reverse string using <c>Array.Reverse</c>.
        /// </summary>
        public static string FastReverse(this string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}