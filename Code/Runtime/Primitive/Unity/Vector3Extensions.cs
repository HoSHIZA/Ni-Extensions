using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class Vector3Extensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Vector3 with the X component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithX(this Vector3 vector, float x) => vector.With(x: x);

        /// <summary>
        /// Returns a new Vector3 with the Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithY(this Vector3 vector, float y) => vector.With(y: y);

        /// <summary>
        /// Returns a new Vector3 with the Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithZ(this Vector3 vector, float z) => vector.With(z: z);

        /// <summary>
        /// Returns a new Vector3 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXY(this Vector3 vector, float x, float y) => vector.With(x: x, y: y);

        #endregion
        
        #region With - 2 Components
        
        /// <summary>
        /// Returns a new Vector3 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXY(this Vector3 vector, Vector2 value) => vector.With(x: value.x, y: value.y);

        /// <summary>
        /// Returns a new Vector3 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXY(this Vector3 vector, float value) => vector.With(x: value, y: value);

        /// <summary>
        /// Returns a new Vector3 with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXZ(this Vector3 vector, float x, float z) => vector.With(x: x, z: z);

        /// <summary>
        /// Returns a new Vector3 with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXZ(this Vector3 vector, Vector2 value) => vector.With(x: value.x, z: value.y);

        /// <summary>
        /// Returns a new Vector3 with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXZ(this Vector3 vector, float value) => vector.With(x: value, z: value);

        /// <summary>
        /// Returns a new Vector3 with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithYZ(this Vector3 vector, float y, float z) => vector.With(y: y, z: z);

        /// <summary>
        /// Returns a new Vector3 with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithYZ(this Vector3 vector, Vector2 value) => vector.With(y: value.x, z: value.y);

        /// <summary>
        /// Returns a new Vector3 with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithYZ(this Vector3 vector, float value) => vector.With(y: value, z: value);

        #endregion
        
        #region With - 3 Components
        
        /// <summary>
        /// Returns a new Vector3 with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXYZ(this Vector3 vector, float x, float y, float z) => vector.With(x: x, y: y, z: z);

        /// <summary>
        /// Returns a new Vector3 with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXYZ(this Vector3 vector, Vector3 value) => vector.With(x: value.x, y: value.y, z: value.z);

        /// <summary>
        /// Returns a new Vector3 with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 WithXYZ(this Vector3 vector, float value) => vector.With(x: value, y: value, z: value);

        #endregion

        #region Get - By Pattern

        /// <summary>
        /// Returns a Vector2 following the specified axis.
        /// </summary>
        public static Vector2 Get(in this Vector3 vector, Vec3Axis x, Vec3Axis y)
        {
            return new Vector2(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y));
        }
        
        /// <summary>
        /// Returns a Vector3 following the specified axis.
        /// </summary>
        public static Vector3 Get(in this Vector3 vector, Vec3Axis x, Vec3Axis y, Vec3Axis z)
        {
            return new Vector3(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y), vector.GetValueFromAxis(z));
        }
        
        /// <summary>
        /// Returns a Vector4 following the specified axis.
        /// </summary>
        public static Vector4 Get(in this Vector3 vector, Vec3Axis x, Vec3Axis y, Vec3Axis z, Vec3Axis w)
        {
            return new Vector4(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y), vector.GetValueFromAxis(z), 
                vector.GetValueFromAxis(w));
        }

        #endregion
        
        #region Get - 2 Components
        
        /// <summary>
        /// Gets a new Vector2 with the X and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetXY(in this Vector3 vector) => new(vector.x, vector.y);

        /// <summary>
        /// Gets a new Vector2 with the X and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetXZ(in this Vector3 vector) => new(vector.x, vector.z);

        /// <summary>
        /// Gets a new Vector2 with the Y and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetYX(in this Vector3 vector) => new(vector.y, vector.x);

        /// <summary>
        /// Gets a new Vector2 with the Y and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetYZ(in this Vector3 vector) => new(vector.y, vector.z);

        /// <summary>
        /// Gets a new Vector2 with the Z and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetZX(in this Vector3 vector) => new(vector.z, vector.x);
        
        /// <summary>
        /// Gets a new Vector2 with the Z and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetZY(in this Vector3 vector) => new(vector.z, vector.y);

        #endregion
        
        #region Get - 3 Components
        
        /// <summary>
        /// Gets a new Vector3 with the X, Z, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetXZY(in this Vector3 vector) => new(vector.x, vector.z, vector.y);

        /// <summary>
        /// Gets a new Vector3 with the Y, X, and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetYXZ(in this Vector3 vector) => new(vector.y, vector.x, vector.z);

        /// <summary>
        /// Gets a new Vector3 with the Y, Z, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetYZX(in this Vector3 vector) => new(vector.y, vector.z, vector.x);

        /// <summary>
        /// Gets a new Vector3 with the Z, X, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetZXY(in this Vector3 vector) => new(vector.z, vector.x, vector.y);

        /// <summary>
        /// Gets a new Vector3 with the Z, Y, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetZYX(in this Vector3 vector) => new(vector.z, vector.y, vector.x);

        #endregion
        
        #region Insert
        
        /// <summary>
        /// Inserts the specified X value into the Vector3, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertX(this Vector3 vector, float x) => new(x, vector.x, vector.y, vector.z);

        /// <summary>
        /// Inserts the specified Y value into the Vector3, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertY(this Vector3 vector, float y) => new(vector.x, y, vector.y, vector.z);

        /// <summary>
        /// Inserts the specified Z value into the Vector3, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertZ(this Vector3 vector, float z) => new(vector.x, vector.y, z, vector.z);

        /// <summary>
        /// Inserts the specified W value into the Vector3, resulting in a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertW(this Vector3 vector, float w) => new(vector.x, vector.y, vector.z, w);

        #endregion
        
        #region Min/Max
        
        /// <summary>
        /// Returns the minimum value of the Vector3 components.
        /// </summary>
        [MethodImpl(256)]
        public static float MinValue(this Vector3 vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector3 components.
        /// </summary>
        [MethodImpl(256)]
        public static float MaxValue(this Vector3 vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector3 (0 is X, 1 is Y, 2 is Z).
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValueIndex(this Vector3 vector)
        {
            if (vector.x > vector.y && vector.x > vector.z) return 0;
            return vector.y > vector.z ? 1 : 2;
        }

        /// <summary>
        /// Returns the name of the largest component of the Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static char MaxValueName(this Vector3 vector)
        {
            if (vector.x > vector.y && vector.x > vector.z) return 'x';
            return vector.y > vector.z ? 'y' : 'z';
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector3 (0 is X, 1 is Y, 2 is Z).
        /// </summary>
        [MethodImpl(256)]
        public static int MinValueIndex(this Vector3 vector)
        {
            if (vector.x < vector.y && vector.x < vector.z) return 0;
            return vector.y < vector.z ? 1 : 2;
        }
        
        /// <summary>
        /// Returns the name of the smallest component of the Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static char MinValueName(this Vector3 vector)
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
        public static float Sum(this Vector3 vector)
        {
            return vector.x + vector.y + vector.z;
        }

        /// <summary>
        /// Remaps all components of a Vector3 from one range of values to another.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="min1">The minimum value of the starting range.</param>
        /// <param name="max1">The maximum value of the starting range.</param>
        /// <param name="min2">The minimum value of the target range.</param>
        /// <param name="max2">The maximum value of the target range.</param>
        /// <returns>A new Vector3 with remapped components.</returns>
        [MethodImpl(256)]
        public static Vector3 Remap(this Vector3 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector3(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2), 
                vector.z.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Abs(this Vector3 vector)
        {
            return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        /// <summary>
        /// Adds a float value to all components of a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Add(this Vector3 vector, float value)
        {
            return new Vector3(vector.x + value, vector.y + value, vector.z + value);
        }

        /// <summary>
        /// Adds float values to X, Y, and Z components of a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Add(this Vector3 vector, float x, float y, float z)
        {
            return new Vector3(vector.x + x, vector.y + y, vector.z + z);
        }

        /// <summary>
        /// Subtracts a float value from all components of a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Subtract(this Vector3 vector, float value)
        {
            return new Vector3(vector.x - value, vector.y - value, vector.z - value);
        }

        /// <summary>
        /// Subtracts float values from X, Y, and Z components of a Vector3.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Subtract(this Vector3 vector, float x, float y, float z)
        {
            return new Vector3(vector.x - x, vector.y - y, vector.z - z);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Clamp(this Vector3 vector, float min, float max)
        {
            return new Vector3(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), 
                Mathf.Clamp(vector.z, min, max));
        }

        /// <summary>
        /// Returns a vector whose components are clamped between 0 and 1.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 Clamp01(this Vector3 vector)
        {
            return new Vector3(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y), Mathf.Clamp01(vector.z));
        }

        /// <summary>
        /// Checks if all elements in the Vector3 are approximately equal.
        /// </summary>
        /// <returns>Returns true if all elements in the Vector3 are approximately equal; false otherwise.</returns>
        [MethodImpl(256)]
        public static bool IsUniform(this Vector3 vector)
        {
            return Mathf.Approximately(vector.x, vector.y) && Mathf.Approximately(vector.y, vector.z);
        }
        
        #endregion
        
        public static Vector3 With(this Vector3 vector, in float x = float.NaN, in float y = float.NaN, in float z = float.NaN)
        {
            if (!float.IsNaN(x)) vector.x = x;
            if (!float.IsNaN(y)) vector.y = y;
            if (!float.IsNaN(z)) vector.z = z;
            
            return vector;
        }
    }
}