using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class Vector4Extensions
    {
        #region With - 1 Component
        
        /// <summary>
        /// Returns a new Vector4 with the X component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithX(this Vector4 vector, float x) => vector.With(x: x);

        /// <summary>
        /// Returns a new Vector4 with the Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithY(this Vector4 vector, float y) => vector.With(y: y);

        /// <summary>
        /// Returns a new Vector4 with the Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithZ(this Vector4 vector, float z) => vector.With(z: z);

        #endregion
        
        #region With - 2 Component
        
        /// <summary>
        /// Returns a new Vector4 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXY(this Vector4 vector, float x, float y) => vector.With(x: x, y: y);

        /// <summary>
        /// Returns a new Vector4 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXY(this Vector4 vector, Vector2 value) => vector.With(x: value.x, y: value.y);

        /// <summary>
        /// Returns a new Vector4 with the X and Y component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXY(this Vector4 vector, float value) => vector.With(x: value, y: value);

        /// <summary>
        /// Returns a new Vector4 with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXZ(this Vector4 vector, float x, float z) => vector.With(x: x, z: z);

        /// <summary>
        /// Returns a new Vector4 with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXZ(this Vector4 vector, Vector2 value) => vector.With(x: value.x, z: value.y);

        /// <summary>
        /// Returns a new Vector4 with the X and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXZ(this Vector4 vector, float value) => vector.With(x: value, z: value);

        /// <summary>
        /// Returns a new Vector4 with the X and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXW(this Vector4 vector, float x, float w) => vector.With(x: x, w: w);

        /// <summary>
        /// Returns a new Vector4 with the X and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXW(this Vector4 vector, Vector2 value) => vector.With(x: value.x, w: value.y);

        /// <summary>
        /// Returns a new Vector4 with the X and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXW(this Vector4 vector, float value) => vector.With(x: value, w: value);

        /// <summary>
        /// Returns a new Vector4 with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYZ(this Vector4 vector, float y, float z) => vector.With(y: y, z: z);

        /// <summary>
        /// Returns a new Vector4 with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYZ(this Vector4 vector, Vector2 value) => vector.With(y: value.x, z: value.y);

        /// <summary>
        /// Returns a new Vector4 with the Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYZ(this Vector4 vector, float value) => vector.With(y: value, z: value);

        /// <summary>
        /// Returns a new Vector4 with the Y and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYW(this Vector4 vector, float y, float w) => vector.With(y: y, w: w);

        /// <summary>
        /// Returns a new Vector4 with the Y and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYW(this Vector4 vector, Vector2 value) => vector.With(y: value.x, w: value.y);

        /// <summary>
        /// Returns a new Vector4 with the Y and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYW(this Vector4 vector, float value) => vector.With(y: value, w: value);

        /// <summary>
        /// Returns a new Vector4 with the Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithZW(this Vector4 vector, float z, float w) => vector.With(z: z, w: w);

        /// <summary>
        /// Returns a new Vector4 with the Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithZW(this Vector4 vector, Vector2 value) => vector.With(z: value.x, w: value.y);

        /// <summary>
        /// Returns a new Vector4 with the Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithZW(this Vector4 vector, float value) => vector.With(z: value, w: value);

        #endregion
        
        #region With - 3 Components
        
        /// <summary>
        /// Returns a new Vector4 with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYZ(this Vector4 vector, float x, float y, float z) => vector.With(x: x, y: y, z: z);

        /// <summary>
        /// Returns a new Vector4 with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYZ(this Vector4 vector, Vector3 value) => vector.With(x: value.x, y: value.y, z: value.z);

        /// <summary>
        /// Returns a new Vector4 with the X, Y and Z component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYZ(this Vector4 vector, float value) => vector.With(x: value, y: value, z: value);

        /// <summary>
        /// Returns a new Vector4 with the X, Y and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYW(this Vector4 vector, float x, float y, float w) => vector.With(x: x, y: y, w: w);

        /// <summary>
        /// Returns a new Vector4 with the X, Y and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYW(this Vector4 vector, Vector3 value) => vector.With(x: value.x, y: value.y, w: value.z);

        /// <summary>
        /// Returns a new Vector4 with the X, Y and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYW(this Vector4 vector, float value) => vector.With(x: value, y: value, w: value);

        /// <summary>
        /// Returns a new Vector4 with the X, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXZW(this Vector4 vector, float x, float z, float w) => vector.With(x: x, z: z, w: w);

        /// <summary>
        /// Returns a new Vector4 with the X, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXZW(this Vector4 vector, Vector3 value) => vector.With(x: value.x, z: value.z, w: value.z);

        /// <summary>
        /// Returns a new Vector4 with the X, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXZW(this Vector4 vector, float value) => vector.With(x: value, z: value, w: value);

        /// <summary>
        /// Returns a new Vector4 with the Y, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYZW(this Vector4 vector, float y, float z, float w) => vector.With(y: y, z: z, w: w);

        /// <summary>
        /// Returns a new Vector4 with the Y, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYZW(this Vector4 vector, Vector3 value) => vector.With(y: value.x, z: value.y, w: value.z);

        /// <summary>
        /// Returns a new Vector4 with the Y, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithYZW(this Vector4 vector, float value) => vector.With(y: value, z: value, w: value);

        #endregion
        
        #region With - 4 Components
        
        /// <summary>
        /// Returns a new Vector4 with the X, Y, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYZW(this Vector4 vector, float x, float y, float z, float w) => vector.With(x: x, y: y, z: z, w: w);

        /// <summary>
        /// Returns a new Vector4 with the X, Y, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYZW(this Vector4 vector, Vector4 value) => vector.With(x: value.x, y: value.y, z: value.z, w: value.w);

        /// <summary>
        /// Returns a new Vector4 with the X, Y, Z and W component set to the given value.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 WithXYZW(this Vector4 vector, float value) => vector.With(x: value, y: value, z: value, w: value);

        #endregion

        #region Get - By Pattern

        /// <summary>
        /// Returns a Vector2 following the specified axis.
        /// </summary>
        public static Vector2 Get(in this Vector4 vector, Vec4Axis x, Vec4Axis y)
        {
            return new Vector2(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y));
        }
        
        /// <summary>
        /// Returns a Vector3 following the specified axis.
        /// </summary>
        public static Vector3 Get(in this Vector4 vector, Vec4Axis x, Vec4Axis y, Vec4Axis z)
        {
            return new Vector3(vector.GetValueFromAxis(x), vector.GetValueFromAxis(y), vector.GetValueFromAxis(z));
        }
        
        /// <summary>
        /// Returns a Vector4 following the specified axis.
        /// </summary>
        public static Vector4 Get(in this Vector4 vector, Vec4Axis x, Vec4Axis y, Vec4Axis z, Vec4Axis w)
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
        public static Vector2 GetXY(in this Vector4 vector) => new(vector.x, vector.y);

        /// <summary>
        /// Gets a new Vector2 with the X and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetXZ(in this Vector4 vector) => new(vector.x, vector.z);

        /// <summary>
        /// Gets a new Vector2 with the X and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetXW(in this Vector4 vector) => new(vector.x, vector.w);
        
        /// <summary>
        /// Gets a new Vector2 with the Y and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetYX(in this Vector4 vector) => new(vector.y, vector.x);

        /// <summary>
        /// Gets a new Vector2 with the Y and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetYZ(in this Vector4 vector) => new(vector.y, vector.z);
        
        /// <summary>
        /// Gets a new Vector2 with the Y and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetYW(in this Vector4 vector) => new(vector.y, vector.w);

        /// <summary>
        /// Gets a new Vector2 with the Z and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetZX(in this Vector4 vector) => new(vector.z, vector.x);
        
        /// <summary>
        /// Gets a new Vector2 with the Z and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetZY(in this Vector4 vector) => new(vector.z, vector.y);
        
        /// <summary>
        /// Gets a new Vector2 with the Z and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetZW(in this Vector4 vector) => new(vector.z, vector.w);
        
        /// <summary>
        /// Gets a new Vector2 with the W and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetWX(in this Vector4 vector) => new(vector.w, vector.x);
        
        /// <summary>
        /// Gets a new Vector2 with the W and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetWY(in this Vector4 vector) => new(vector.w, vector.y);
        
        /// <summary>
        /// Gets a new Vector2 with the W and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector2 GetWZ(in this Vector4 vector) => new(vector.w, vector.z);
        
        #endregion
        
        #region Get - 3 Components
        
        /// <summary>
        /// Gets a new Vector3 with the X, Y, and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetXYZ(in this Vector4 vector) => new(vector.x, vector.y, vector.z);
        
        /// <summary>
        /// Gets a new Vector3 with the X, Y, and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetXYW(in this Vector4 vector) => new(vector.x, vector.y, vector.w);
        
        /// <summary>
        /// Gets a new Vector3 with the X, Z, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetXZY(in this Vector4 vector) => new(vector.x, vector.z, vector.y);
        
        /// <summary>
        /// Gets a new Vector3 with the X, Z, and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetXZW(in this Vector4 vector) => new(vector.x, vector.z, vector.w);
        
        /// <summary>
        /// Gets a new Vector3 with the Y, X, and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetYXZ(in this Vector4 vector) => new(vector.y, vector.x, vector.z);
        
        /// <summary>
        /// Gets a new Vector3 with the Y, X, and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetYXW(in this Vector4 vector) => new(vector.y, vector.x, vector.w);

        /// <summary>
        /// Gets a new Vector3 with the Y, Z, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetYZX(in this Vector4 vector) => new(vector.y, vector.z, vector.w);

        /// <summary>
        /// Gets a new Vector3 with the Y, Z, and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetYZW(in this Vector4 vector) => new(vector.y, vector.z, vector.w);

        /// <summary>
        /// Gets a new Vector3 with the Z, X, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetZXY(in this Vector4 vector) => new(vector.z, vector.x, vector.y);

        /// <summary>
        /// Gets a new Vector3 with the Z, X, and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetZXW(in this Vector4 vector) => new(vector.z, vector.x, vector.w);

        /// <summary>
        /// Gets a new Vector3 with the Z, Y, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetZYX(in this Vector4 vector) => new(vector.z, vector.y, vector.x);
        
        /// <summary>
        /// Gets a new Vector3 with the Z, Y, and W components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetZYW(in this Vector4 vector) => new(vector.z, vector.y, vector.w);
        
        /// <summary>
        /// Gets a new Vector3 with the W, X, and Y components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetWXY(in this Vector4 vector) => new(vector.w, vector.x, vector.y);
        
        /// <summary>
        /// Gets a new Vector3 with the W, X, and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetWXZ(in this Vector4 vector) => new(vector.w, vector.x, vector.z);
        
        /// <summary>
        /// Gets a new Vector3 with the W, Y, and X components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetWYX(in this Vector4 vector) => new(vector.w, vector.y, vector.x);
        
        /// <summary>
        /// Gets a new Vector3 with the W, Y, and Z components of the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector3 GetWYZ(in this Vector4 vector) => new(vector.w, vector.y, vector.z);
        
        #endregion
        
        #region Insert
        
        /// <summary>
        /// Inserts the specified X value into the Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertX(this Vector4 vector, float x) => new(x, vector.x, vector.y, vector.z);

        /// <summary>
        /// Inserts the specified Y value into the Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertY(this Vector4 vector, float y) => new(vector.x, y, vector.y, vector.z);

        /// <summary>
        /// Inserts the specified Z value into the Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertZ(this Vector4 vector, float z) => new(vector.x, vector.y, z, vector.z);

        /// <summary>
        /// Inserts the specified W value into the Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 InsertW(this Vector4 vector, float w) => new(vector.x, vector.y, vector.z, w);

        #endregion
        
        #region Min/Max
        
        /// <summary>
        /// Returns the minimum value of the Vector4 components.
        /// </summary>
        [MethodImpl(256)]
        public static float MinValue(this Vector4 vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector4 components.
        /// </summary>
        [MethodImpl(256)]
        public static float MaxValue(this Vector4 vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector4 (0 is X, 1 is Y, 2 is Z, 3 is W).
        /// </summary>
        [MethodImpl(256)]
        public static int MaxValueIndex(this Vector4 vector)
        {
            if (vector.x > vector.y && vector.x > vector.z && vector.z > vector.w) return 0;
            if (vector.y > vector.z && vector.y > vector.w) return 1;
            return vector.z > vector.w ? 2 : 3;
        }

        /// <summary>
        /// Returns the name of the largest component of the Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static char MaxValueName(this Vector4 vector)
        {
            if (vector.x > vector.y && vector.x > vector.z && vector.z > vector.w) return 'x';
            if (vector.y > vector.z && vector.y > vector.w) return 'y';
            return vector.z > vector.w ? 'z' : 'w';
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector4 (0 is X, 1 is Y, 2 is Z, 3 is W).
        /// </summary>
        [MethodImpl(256)]
        public static int MinValueIndex(this Vector4 vector)
        {
            if (vector.x < vector.y && vector.x < vector.z && vector.x < vector.w) return 0;
            if (vector.y < vector.z && vector.y < vector.w) return 1;
            return vector.z < vector.w ? 2 : 3;
        }

        /// <summary>
        /// Returns the name of the smallest component of the Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static char MinValueName(this Vector4 vector)
        {
            if (vector.x < vector.y && vector.x < vector.z && vector.x < vector.w) return 'x';
            if (vector.y < vector.z && vector.y < vector.w) return 'y';
            return vector.z < vector.w ? 'z' : 'w';
        }
        
        #endregion
        
        #region Math
        
        /// <summary>
        /// Returns the sum of all components of the vector.
        /// </summary>
        [MethodImpl(256)]
        public static float Sum(this Vector4 vector)
        {
            return vector.x + vector.y + vector.z + vector.w;
        }

        /// <summary>
        /// Remaps all components of a Vector4 from one range of values to another.
        /// </summary>
        /// <param name="vector">The original Vector4.</param>
        /// <param name="min1">The minimum value of the starting range.</param>
        /// <param name="max1">The maximum value of the starting range.</param>
        /// <param name="min2">The minimum value of the target range.</param>
        /// <param name="max2">The maximum value of the target range.</param>
        /// <returns>A new Vector4 with remapped components.</returns>
        [MethodImpl(256)]
        public static Vector4 Remap(this Vector4 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector4(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2), 
                vector.z.Remap(min1, max1, min2, max2), vector.w.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Abs(this Vector4 vector)
        {
            return new Vector4(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z), Mathf.Abs(vector.w));
        }

        /// <summary>
        /// Adds a float value to all components of a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Add(this Vector4 vector, float value)
        {
            return new Vector4(vector.x + value, vector.y + value, vector.z + value, vector.w + value);
        }

        /// <summary>
        /// Adds float values to X, Y, Z and W components of a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Add(this Vector4 vector, float x, float y, float z, float w)
        {
            return new Vector4(vector.x + x, vector.y + y, vector.z + z, vector.w + w);
        }

        /// <summary>
        /// Subtracts a float value from all components of a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Subtract(this Vector4 vector, float value)
        {
            return new Vector4(vector.x - value, vector.y - value, vector.z - value, vector.w - value);
        }

        /// <summary>
        /// Subtracts float values from X, Y, Z and W components of a Vector4.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Subtract(this Vector4 vector, float x, float y, float z, float w)
        {
            return new Vector4(vector.x - x, vector.y - y, vector.z - z, vector.w - w);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Clamp(this Vector4 vector, float min, float max)
        {
            return new Vector4(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), 
                Mathf.Clamp(vector.z, min, max), Mathf.Clamp(vector.w, min, max));
        }
        
        /// <summary>
        /// Returns a vector whose components are clamped between 0 and 1.
        /// </summary>
        [MethodImpl(256)]
        public static Vector4 Clamp01(this Vector4 vector)
        {
            return new Vector4(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y), Mathf.Clamp01(vector.z), Mathf.Clamp01(vector.w));
        }
        
        /// <summary>
        /// Checks if all elements in the Vector4 are approximately equal.
        /// </summary>
        /// <returns>Returns true if all elements in the Vector4 are approximately equal; false otherwise.</returns>
        [MethodImpl(256)]
        public static bool IsUniform(this Vector4 vector)
        {
            return Mathf.Approximately(vector.x, vector.y) && 
                   Mathf.Approximately(vector.y, vector.z) &&
                   Mathf.Approximately(vector.z, vector.w);
        }
        
        #endregion
        
        public static Vector4 With(this Vector4 vector, in float x = float.NaN, in float y = float.NaN, in float z = float.NaN, in float w = float.NaN)
        {
            if (!float.IsNaN(x)) vector.x = x;
            if (!float.IsNaN(y)) vector.y = y;
            if (!float.IsNaN(z)) vector.z = z;
            if (!float.IsNaN(w)) vector.w = z;
            
            return vector;
        }
    }
}