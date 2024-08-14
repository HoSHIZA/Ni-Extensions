using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class Vector2Extensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Vector2 with the X component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 WithX(this Vector2 vector, float x) => vector.With(x: x);

        /// <summary>
        /// Returns a new Vector2 with the Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 WithY(this Vector2 vector, float y) => vector.With(y: y);

        #endregion
        
        #region With - 2 Components

        /// <summary>
        /// Returns a new Vector2 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 WithXY(this Vector2 vector, float x, float y) => vector.With(x: x, y: y);

        /// <summary>
        /// Returns a new Vector2 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 WithXY(this Vector2 vector, Vector2 value) => vector.With(x: value.x, y: value.y);

        /// <summary>
        /// Returns a new Vector2 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 WithXY(this Vector2 vector, float value) => vector.With(x: value, y: value);

        #endregion

        #region Get - By Pattern

        /// <summary>
        /// Returns a Vector2 following the specified axis.
        /// </summary>
        public static Vector2 Get(in this Vector2 vector, Vec2Axis x, Vec2Axis y)
        {
            return new Vector2(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y));
        }
        
        /// <summary>
        /// Returns a Vector3 following the specified axis.
        /// </summary>
        public static Vector3 Get(in this Vector2 vector, Vec2Axis x, Vec2Axis y, Vec2Axis z)
        {
            return new Vector3(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y), vector.GetValueFromAxis(z));
        }
        
        /// <summary>
        /// Returns a Vector4 following the specified axis.
        /// </summary>
        public static Vector4 Get(in this Vector2 vector, Vec2Axis x, Vec2Axis y, Vec2Axis z, Vec2Axis w)
        {
            return new Vector4(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y), vector.GetValueFromAxis(z), 
                vector.GetValueFromAxis(w));
        }

        #endregion
        
        #region Get - 2 Components
        
        /// <summary>
        /// Returns a new Vector2 object with the X and Y components swapped.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetYX(in this Vector2 vector) => new(vector.y, vector.x);

        #endregion

        #region Insert
        
        /// <summary>
        /// Inserts the specified X value into the Vector2, resulting in a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 InsertX(this Vector2 vector, float x) => new(x, vector.x, vector.y);

        /// <summary>
        /// Inserts the specified Y value into the Vector2, resulting in a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 InsertY(this Vector2 vector, float y) => new(vector.x, y, vector.y);

        /// <summary>
        /// Inserts the specified Z value into the Vector2, resulting in a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 InsertZ(this Vector2 vector, float z) => new(vector.x, vector.y, z);

        #endregion
        
        #region Min/Max

        /// <summary>
        /// Returns the minimum value of the Vector2 components.
        /// </summary>
        [MethodImpl(256)]
        public static float MinValue(this Vector2 vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector2 components.
        /// </summary>
        [MethodImpl(256)]
        public static float MaxValue(this Vector2 vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }
        
        /// <summary>
        /// Returns the index of the largest component of the Vector2 (0 is X, 1 is Y).
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValueIndex(this Vector2 vector)
        {
            return vector.x > vector.y ? 0 : 1;
        }
        
        /// <summary>
        /// Returns the name of the largest component of the Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static char MaxValueName(this Vector2 vector)
        {
            return vector.x > vector.y ? 'x' : 'y';
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector2 (0 is X, 1 is Y).
        /// </summary>
        [MethodImpl(256)]
        public static int MinValueIndex(this Vector2 vector)
        {
            return vector.x < vector.y ? 0 : 1;
        }

        /// <summary>
        /// Returns the name of the smallest component of the Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static char MinValueName(this Vector2 vector)
        {
            return vector.x < vector.y ? 'x' : 'y';
        }
        
        #endregion
        
        #region Math

        /// <summary>
        /// Returns the sum of all components of the vector.
        /// </summary>
        [MethodImpl(256)]
        public static float Sum(this Vector2 vector)
        {
            return vector.x + vector.y;
        }

        /// <summary>
        /// Remaps all components of a Vector2 from one range of values to another.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="min1">The minimum value of the starting range.</param>
        /// <param name="max1">The maximum value of the starting range.</param>
        /// <param name="min2">The minimum value of the target range.</param>
        /// <param name="max2">The maximum value of the target range.</param>
        [MethodImpl(256)]
        public static Vector2 Remap(this Vector2 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector2(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Abs(this Vector2 vector)
        {
            return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Adds a float value to all components of a Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Add(this Vector2 vector, float value)
        {
            return new Vector2(vector.x + value, vector.y + value);
        }

        /// <summary>
        /// Adds float values to X and Y components of a Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Add(this Vector2 vector, float x, float y)
        {
            return new Vector2(vector.x + x, vector.y + y);
        }

        /// <summary>
        /// Subtracts a Vector2 value from a Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Subtract(this Vector2 vector, Vector2 value)
        {
            return new Vector2(vector.x - value.x, vector.y - value.y);
        }

        /// <summary>
        /// Subtracts a float value from all components of a Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Subtract(this Vector2 vector, float value)
        {
            return new Vector2(vector.x - value, vector.y - value);
        }

        /// <summary>
        /// Subtracts float values from X and Y components of a Vector2.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Subtract(this Vector2 vector, float x, float y)
        {
            return new Vector2(vector.x - x, vector.y - y);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Clamp(this Vector2 vector, float min, float max)
        {
            return new Vector2(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }
        
        /// <summary>
        /// Returns a vector whose components are clamped between 0 and 1.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 Clamp01(this Vector2 vector)
        {
            return new Vector2(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y));
        }
        
        /// <summary>
        /// Checks if all elements in the Vector2 are approximately equal.
        /// </summary>
        /// <returns>Returns true if all elements in the Vector2 are approximately equal; false otherwise.</returns>
        [MethodImpl(256)]
        public static bool IsUniform(this Vector2 vector)
        {
            return Mathf.Approximately(vector.x, vector.y);
        }
        
        #endregion
        
        public static Vector2 With(this Vector2 vector, in float x = float.NaN, in float y = float.NaN)
        {
            if (!float.IsNaN(x)) vector.x = x;
            if (!float.IsNaN(y)) vector.y = y;
            
            return vector;
        }
    }
}