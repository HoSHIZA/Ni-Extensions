using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class Vector2IntExtensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Vector2Int with the X component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int WithX(this Vector2Int vector, int x) => vector.With(x: x);

        /// <summary>
        /// Returns a new Vector2Int with the Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int WithY(this Vector2Int vector, int y) => vector.With(y: y);

        #endregion
        
        #region With - 2 Components
        
        /// <summary>
        /// Returns a new Vector2Int with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int WithXY(this Vector2Int vector, int x, int y) => vector.With(x: x, y: y);
        
        /// <summary>
        /// Returns a new Vector2Int with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int WithXY(this Vector2Int vector, Vector2Int value) => vector.With(x: value.x, y: value.y);
        
        /// <summary>
        /// Returns a new Vector2Int with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int WithXY(this Vector2Int vector, int value) => vector.With(x: value, y: value);
        
        #endregion
        
        #region Get - 2 Components
        
        /// <summary>
        /// Returns a new Vector2Int with X and Y components swapped.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetYX(this Vector2Int vector) => new(vector.y, vector.x);

        #endregion
        
        #region Insert
        
        /// <summary>
        /// Inserts the specified X value into the Vector2Int, resulting in a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int InsertX(this Vector2Int vector, int x) => new(x, vector.x, vector.y);

        /// <summary>
        /// Inserts the specified Y value into the Vector2Int, resulting in a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int InsertY(this Vector2Int vector, int y) => new(vector.x, y, vector.y);

        /// <summary>
        /// Inserts the specified Z value into the Vector2Int, resulting in a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int InsertZ(this Vector2Int vector, int z) => new(vector.x, vector.y, z);
        
        #endregion

        #region Min/Max
        
        /// <summary>
        /// Returns the minimum value of the Vector2Int components.
        /// </summary>
        [MethodImpl(256)]
        public static int MinValue(this Vector2Int vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector2Int components.
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValue(this Vector2Int vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector2Int (0 is X, 1 is Y).
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValueIndex(this Vector2Int vector)
        {
            return vector.x > vector.y ? 0 : 1;
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector2Int (0 is X, 1 is Y).
        /// </summary>
        [MethodImpl(256)]
        public static int MinValueIndex(this Vector2Int vector)
        {
            return vector.x < vector.y ? 0 : 1;
        }
        
        #endregion
        
        #region Math
        
        /// <summary>
        /// Returns the sum of all components of the vector.
        /// </summary>
        [MethodImpl(256)]
        public static int Sum(this Vector2Int vector)
        {
            return vector.x + vector.y;
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original Vector2Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int Abs(this Vector2Int vector)
        {
            return new Vector2Int(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Adds an int value to all components of a Vector2Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int Add(this Vector2Int vector, int value)
        {
            return new Vector2Int(vector.x + value, vector.y + value);
        }

        /// <summary>
        /// Adds int values to X and Y components of a Vector2Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int Add(this Vector2Int vector, int x, int y)
        {
            return new Vector2Int(vector.x + x, vector.y + y);
        }

        /// <summary>
        /// Subtracts an int value from all components of a Vector2Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int Subtract(this Vector2Int vector, int value)
        {
            return new Vector2Int(vector.x - value, vector.y - value);
        }

        /// <summary>
        /// Subtracts int values from X and Y components of a Vector2Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int Subtract(this Vector2Int vector, int x, int y)
        {
            return new Vector2Int(vector.x - x, vector.y - y);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int Clamp(this Vector2Int vector, int min, int max)
        {
            return new Vector2Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }
        
        /// <summary>
        /// Checks if all elements in the Vector2Int are approximately equal.
        /// </summary>
        /// <returns>Returns true if all elements in the Vector2Int are approximately equal; false otherwise.</returns>
        [MethodImpl(256)]
        public static bool IsUniform(this Vector2Int vector)
        {
            return Mathf.Approximately(vector.x, vector.y);
        }
        
        #endregion
        
        public static Vector2Int With(this Vector2Int vector, in int? x = null, in int? y = null)
        {
            if (x.HasValue) vector.x = x.Value;
            if (y.HasValue) vector.y = y.Value;

            return vector;
        }
    }
}