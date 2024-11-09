using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class ColorExtensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Color with the red channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithR(this Color color, float r) => color.With(r: r);
        
        /// <summary>
        /// Returns a new Color with the green channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithG(this Color color, float g) => color.With(g: g);
        
        /// <summary>
        /// Returns a new Color with the blue channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithB(this Color color, float b) => color.With(b: b);
        
        /// <summary>
        /// Returns a new Color with the alpha channel replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithA(this Color color, float a) => color.With(a: a);
        
        #endregion
        
        #region With - 2 Components
        
        /// <summary>
        /// Returns a new Color with the red and green channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRG(this Color color, float r, float g) => color.With(r: r, g: g);
        
        /// <summary>
        /// Returns a new Color with the red and blue channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRB(this Color color, float r, float b) => color.With(r: r, b: b);
        
        /// <summary>
        /// Returns a new Color with the red and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRA(this Color color, float r, float a) => color.With(r: r, a: a);
        
        /// <summary>
        /// Returns a new Color with the green and blue channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithGB(this Color color, float g, float b) => color.With(g: g, b: b);
        
        /// <summary>
        /// Returns a new Color with the green and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithGA(this Color color, float g, float a) => color.With(g: g, a: a);
        
        /// <summary>
        /// Returns a new Color with the blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithBA(this Color color, float b, float a) => color.With(b: b, a: a);
        
        #endregion
        
        #region With - 3 Components
        
        /// <summary>
        /// Returns a new Color with the red, green and blue channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRGB(this Color color, float r, float g, float b) => color.With(r: r, g: g, b: b);
        
        /// <summary>
        /// Returns a new Color with the red, green and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRGA(this Color color, float r, float g, float a) => color.With(r: r, g: g, a: a);
        
        /// <summary>
        /// Returns a new Color with the red, blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRBA(this Color color, float r, float b, float a) => color.With(r: r, b: b, a: a);
        
        /// <summary>
        /// Returns a new Color with the green, blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithGBA(this Color color, float g, float b, float a) => color.With(g: g, b: b, a: a);
        
        #endregion
        
        #region With - 4 Components
        
        /// <summary>
        /// Returns a new Color with the red, green, blue and alpha channels replaced by the specified values.
        /// </summary>
        [MethodImpl(256)]
        public static Color WithRGBA(this Color color, float r, float g, float b, float a) => color.With(r: r, g: g, b: b, a: a);
        
        #endregion
        
        #region As

        /// <summary>
        /// Returns the color as a hexadecimal string in the format "RRGGBB".
        /// </summary>
        [MethodImpl(256)]
        public static string AsHtmlStringRGB(this Color color) => ColorUtility.ToHtmlStringRGB(color);

        /// <summary>
        /// Returns the color as a hexadecimal string in the format "RRGGBBAA".
        /// </summary>
        [MethodImpl(256)]
        public static string AsHtmlStringRGBA(this Color color) => ColorUtility.ToHtmlStringRGBA(color);

        #endregion
        
        public static Color With(this Color color, float r = -1f, float g = -1f, float b = -1f, float a = -1f)
        {
            if (r >= 0f) color.r = Mathf.Clamp01(r);
            if (g >= 0f) color.g = Mathf.Clamp01(g);
            if (b >= 0f) color.b = Mathf.Clamp01(b);
            if (a >= 0f) color.a = Mathf.Clamp01(a);
            
            return color;
        }
    }
}