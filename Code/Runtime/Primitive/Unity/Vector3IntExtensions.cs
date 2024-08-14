using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class Vector3IntExtensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Vector3Int with the X component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithX(this Vector3Int vector, int x) => vector.With(x: x);

        /// <summary>
        /// Returns a new Vector3Int with the Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithY(this Vector3Int vector, int y) => vector.With(y: y);

        /// <summary>
        /// Returns a new Vector3Int with the Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithZ(this Vector3Int vector, int z) => vector.With(z: z);

        #endregion
        
        #region With - 2 Components

        /// <summary>
        /// Returns a new Vector3Int with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXY(this Vector3Int vector, int x, int y) => vector.With(x: x, y: y);

        /// <summary>
        /// Returns a new Vector3Int with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXY(this Vector3Int vector, Vector2Int value) => vector.With(x: value.x, y: value.y);

        /// <summary>
        /// Returns a new Vector3Int with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXY(this Vector3Int vector, int value) => vector.With(x: value, y: value);

        /// <summary>
        /// Returns a new Vector3Int with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXZ(this Vector3Int vector, int x, int z) => vector.With(x: x, z: z);

        /// <summary>
        /// Returns a new Vector3Int with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXZ(this Vector3Int vector, Vector2Int value) => vector.With(x: value.x, z: value.y);

        /// <summary>
        /// Returns a new Vector3Int with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXZ(this Vector3Int vector, int value) => vector.With(x: value, z: value);

        /// <summary>
        /// Returns a new Vector3Int with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithYZ(this Vector3Int vector, int y, int z) => vector.With(y: y, z: z);

        /// <summary>
        /// Returns a new Vector3Int with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithYZ(this Vector3Int vector, Vector2Int value) => vector.With(y: value.x, z: value.y);

        /// <summary>
        /// Returns a new Vector3Int with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithYZ(this Vector3Int vector, int value) => vector.With(y: value, z: value);

        #endregion
        
        #region With - 3 Components
        
        /// <summary>
        /// Returns a new Vector3Int with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXYZ(this Vector3Int vector, int x, int y, int z) => vector.With(x: x, y: y, z: z);

        /// <summary>
        /// Returns a new Vector3Int with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXYZ(this Vector3Int vector, Vector3Int value) => vector.With(x: value.x, y: value.y, z: value.z);

        /// <summary>
        /// Returns a new Vector3Int with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int WithXYZ(this Vector3Int vector, int value) => vector.With(x: value, y: value, z: value);

        #endregion
        
        #region Get - By Pattern

        /// <summary>
        /// Returns a Vector2Int following the specified axis.
        /// </summary>
        public static Vector2Int Get(in this Vector3Int vector, Vec3Axis x, Vec3Axis y)
        {
            return new Vector2Int(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y));
        }
        
        /// <summary>
        /// Returns a Vector3Int following the specified axis.
        /// </summary>
        public static Vector3Int Get(in this Vector3Int vector, Vec3Axis x, Vec3Axis y, Vec3Axis z)
        {
            return new Vector3Int(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y), vector.GetValueFromAxis(z));
        }

        #endregion
        
        #region Get - 2 Components

        /// <summary>
        /// Gets a new Vector2Int with the X and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetXY(in this Vector3Int vector) => new(vector.x, vector.y);

        /// <summary>
        /// Gets a new Vector2Int with the X and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetXZ(in this Vector3Int vector) => new(vector.x, vector.z);

        /// <summary>
        /// Gets a new Vector2Int with the Y and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetYX(in this Vector3Int vector) => new(vector.y, vector.x);

        /// <summary>
        /// Gets a new Vector2Int with the Y and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetYZ(in this Vector3Int vector) => new(vector.y, vector.z);

        /// <summary>
        /// Gets a new Vector2Int with the Z and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetZX(in this Vector3Int vector) => new(vector.z, vector.x);
        
        /// <summary>
        /// Gets a new Vector2Int with the Z and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2Int GetZY(in this Vector3Int vector) => new(vector.z, vector.y);
        
        #endregion

        #region Get - 3 Components

        /// <summary>
        /// Gets a new Vector3Int with the X, Z, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int GetXZY(this Vector3Int vector) => new(vector.x, vector.z, vector.y);

        /// <summary>
        /// Gets a new Vector3Int with the Y, X, and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int GetYXZ(this Vector3Int vector) => new(vector.y, vector.x, vector.z);
        
        /// <summary>
        /// Gets a new Vector3Int with the Y, Z, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int GetYZX(this Vector3Int vector) => new(vector.y, vector.z, vector.x);

        /// <summary>
        /// Gets a new Vector3Int with the Z, X, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int GetZXY(this Vector3Int vector) => new(vector.z, vector.x, vector.y);

        /// <summary>
        /// Gets a new Vector3Int with the Z, Y, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int GetZYX(this Vector3Int vector) => new(vector.z, vector.y, vector.x);

        #endregion
        
        #region Insert
        
        /// <summary>
        /// Inserts the specified X value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertX(this Vector3Int vector, int x) => new(x, vector.x, vector.y, vector.z);

        /// <summary>
        /// Inserts the specified Y value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertY(this Vector3Int vector, int y) => new(vector.x, y, vector.y, vector.z);

        /// <summary>
        /// Inserts the specified Z value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertZ(this Vector3Int vector, int z) => new(vector.x, vector.y, z, vector.z);

        /// <summary>
        /// Inserts the specified W value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertW(this Vector3Int vector, int w) => new(vector.x, vector.y, vector.z, w);

        #endregion
        
        #region Min/Max
        
        /// <summary>
        /// Returns the minimum value of the Vector3Int components.
        /// </summary>
        [MethodImpl(256)]
        public static int MinValue(this Vector3Int vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector3Int components.
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValue(this Vector3Int vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector3Int (0 is X, 1 is Y, 2 is Z).
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValueIndex(this Vector3Int vector)
        {
            if (vector.x > vector.y && vector.x > vector.z) return 0;
            return vector.y > vector.z ? 1 : 2;
        }
        
        /// <summary>
        /// Returns the name of the largest component of the Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static char MaxValueName(this Vector3Int vector)
        {
            if (vector.x > vector.y && vector.x > vector.z) return 'x';
            return vector.y > vector.z ? 'y' : 'z';
        }
        
        /// <summary>
        /// Returns the index of the smallest component of the Vector3Int (0 is X, 1 is Y, 2 is Z).
        /// </summary>
        [MethodImpl(256)]
        public static int MinValueIndex(this Vector3Int vector)
        {
            if (vector.x < vector.y && vector.x < vector.z) return 0;
            return vector.y < vector.z ? 1 : 2;
        }
        
        /// <summary>
        /// Returns the name of the smallest component of the Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static char MinValueName(this Vector3Int vector)
        {
            if (vector.x < vector.y && vector.x < vector.z) return 'x';
            return vector.y < vector.z ? 'y' : 'z';
        }
        
        #endregion
        
        #region Math
        
        /// <summary>
        /// Returns the sum of all components of the vector.
        /// </summary>
        [MethodImpl(256)]
        public static int Sum(this Vector3Int vector)
        {
            return vector.x + vector.y + vector.z;
        }
        
        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int Abs(this Vector3Int vector)
        {
            return new Vector3Int(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        /// <summary>
        /// Adds a int value to all components of a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int Add(this Vector3Int vector, int value)
        {
            return new Vector3Int(vector.x + value, vector.y + value, vector.z + value);
        }

        /// <summary>
        /// Adds int values to X, Y, and Z components of a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int Add(this Vector3Int vector, int x, int y, int z)
        {
            return new Vector3Int(vector.x + x, vector.y + y, vector.z + z);
        }

        /// <summary>
        /// Subtracts a int value from all components of a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int Subtract(this Vector3Int vector, int value)
        {
            return new Vector3Int(vector.x - value, vector.y - value, vector.z - value);
        }

        /// <summary>
        /// Subtracts int values from X, Y, and Z components of a Vector3Int.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int Subtract(this Vector3Int vector, int x, int y, int z)
        {
            return new Vector3Int(vector.x - x, vector.y - y, vector.z - z);
        }
        
        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3Int Clamp(this Vector3Int vector, int min, int max)
        {
            return new Vector3Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), 
                Mathf.Clamp(vector.z, min, max));
        }
        
        /// <summary>
        /// Checks if all elements in the Vector3Int are approximately equal.
        /// </summary>
        /// <returns>Returns true if all elements in the Vector3Int are approximately equal; false otherwise.</returns>
        [MethodImpl(256)]
        public static bool IsUniform(this Vector3Int vector)
        {
            return Mathf.Approximately(vector.x, vector.y) && Mathf.Approximately(vector.y, vector.z);
        }
        
        #endregion
        
        public static Vector3Int With(this Vector3Int vector, int? x = null, int? y = null, int? z = null)
        {
            if (x.HasValue) vector.x = x.Value;
            if (y.HasValue) vector.y = y.Value;
            if (z.HasValue) vector.z = z.Value;
            
            return vector;
        }
    }
}