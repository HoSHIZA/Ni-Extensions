using System.Runtime.CompilerServices;

namespace NiGames.Extensions
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Remap the given value from one range to another.
        /// </summary>
        [MethodImpl(256)]
        public static float Remap(this float value, float min1, float max1, float min2, float max2)
        {
            return (value - min1) / (max1 - min1) * (max2 - min2) + min2;
        }
    }
}