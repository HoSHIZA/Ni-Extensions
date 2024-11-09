using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class Color32Extensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Color32 with the red channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithR(this Color32 color, byte r) => color.With(r: r);
        
        /// <summary>
        /// Returns a new Color32 with the green channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithG(this Color32 color, byte g) => color.With(g: g);
        
        /// <summary>
        /// Returns a new Color32 with the blue channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithB(this Color32 color, byte b) => color.With(b: b);
        
        /// <summary>
        /// Returns a new Color32 with the alpha channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithA(this Color32 color, byte a) => color.With(a: a);
        
        #endregion
        
        #region With - 2 Components
        
        /// <summary>
        /// Returns a new Color32 with the red and green channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRG(this Color32 color, byte r, byte g) => color.With(r: r, g: g);
        
        /// <summary>
        /// Returns a new Color32 with the red and blue channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRB(this Color32 color, byte r, byte b) => color.With(r: r, b: b);
        
        /// <summary>
        /// Returns a new Color32 with the red and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRA(this Color32 color, byte r, byte a) => color.With(r: r, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the green and blue channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithGB(this Color32 color, byte g, byte b) => color.With(g: g, b: b);
        
        /// <summary>
        /// Returns a new Color32 with the green and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithGA(this Color32 color, byte g, byte a) => color.With(g: g, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithBA(this Color32 color, byte b,byte a) => color.With(b: b, a: a);
        
        #endregion
        
        #region With - 3 Components
        
        /// <summary>
        /// Returns a new Color32 with the red, green and blue channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRGB(this Color32 color, byte r, byte g, byte b) => color.With(r: r, g: g, b: b);
        
        /// <summary>
        /// Returns a new Color32 with the red, green and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRGA(this Color32 color, byte r, byte g, byte a) => color.With(r: r, g: g, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the red, blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRBA(this Color32 color, byte r, byte b, byte a) => color.With(r: r, b: b, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the green, blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithGBA(this Color32 color, byte g, byte b, byte a) => color.With(g: g, b: b, a: a);
        
        #endregion
        
        #region With - 4 Components
        
        /// <summary>
        /// Returns a new Color32 with the red, green, blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color32 WithRGBA(this Color32 color, byte r, byte g, byte b, byte a) => color.With(r: r, g: g, b: b, a: a);
        
        #endregion
        
        #region As

        /// <summary>
        /// Returns the color as a hexadecimal string in the format "RRGGBB".
        /// </summary>
        [MethodImpl(256)]
        public static string AsHtmlStringRGB(this Color32 color) => ColorUtility.ToHtmlStringRGB(color);

        /// <summary>
        /// Returns the color as a hexadecimal string in the format "RRGGBBAA".
        /// </summary>
        [MethodImpl(256)]
        public static string AsHtmlStringRGBA(this Color32 color) => ColorUtility.ToHtmlStringRGBA(color);

        #endregion
        
        public static Color32 With(this Color32 color, short r = -1, short g = -1, short b = -1, short a = -1)
        {
            if (r >= 0) color.r = (byte) Math.Clamp(r, byte.MinValue, byte.MaxValue);
            if (g >= 0) color.g = (byte) Math.Clamp(g, byte.MinValue, byte.MaxValue);
            if (b >= 0) color.b = (byte) Math.Clamp(b, byte.MinValue, byte.MaxValue);
            if (a >= 0) color.a = (byte) Math.Clamp(a, byte.MinValue, byte.MaxValue);
            
            return color;
        }
    }
}