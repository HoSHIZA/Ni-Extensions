using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class TransformExtensions
    {
        #region Position
        
        /// <summary>
        /// Sets the position of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetPosition(this Transform transform, float x, float y, float z)
        {
            transform.position = transform.position.WithXYZ(x, y, z);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetPosition(this Transform transform, Vector3 position)
        {
            transform.position = transform.position.WithXYZ(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetPosition(this Transform transform, float position)
        {
            transform.position = transform.position.WithXYZ(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X value.
        /// </summary>
        public static void SetPositionX(this Transform transform, float x)
        {
            transform.position = transform.position.WithX(x);
        }

        /// <summary>
        /// Sets the position of the Transform using specified Y value.
        /// </summary>
        public static void SetPositionY(this Transform transform, float y)
        {
            transform.position = transform.position.WithY(y);
        }

        /// <summary>
        /// Sets the position of the Transform using specified Z value.
        /// </summary>
        public static void SetPositionZ(this Transform transform, float z)
        {
            transform.position = transform.position.WithZ(z);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X and Y values.
        /// </summary>
        
        public static void SetPositionXY(this Transform transform, float x, float y)
        {
            transform.position = transform.position.WithXY(x, y);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X and Y values.
        /// </summary>
        public static void SetPositionXY(this Transform transform, Vector2 position)
        {
            transform.position = transform.position.WithXY(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X and Y values.
        /// </summary>
        public static void SetPositionXY(this Transform transform, float position)
        {
            transform.position = transform.position.WithXY(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X and Z values.
        /// </summary>
        
        public static void SetPositionXZ(this Transform transform, float x, float z)
        {
            transform.position = transform.position.WithXZ(x, z);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X and Z values.
        /// </summary>
        public static void SetPositionXZ(this Transform transform, Vector2 position)
        {
            transform.position = transform.position.WithXZ(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified X and Z values.
        /// </summary>
        public static void SetPositionXZ(this Transform transform, float position)
        {
            transform.position = transform.position.WithXZ(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified Y and Z values.
        /// </summary>
        
        public static void SetPositionYZ(this Transform transform, float y, float z)
        {
            transform.position = transform.position.WithYZ(y, z);
        }

        /// <summary>
        /// Sets the position of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetPositionYZ(this Transform transform, Vector2 position)
        {
            transform.position = transform.position.WithYZ(position);
        }

        /// <summary>
        /// Sets the position of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetPositionYZ(this Transform transform, float position)
        {
            transform.position = transform.position.WithYZ(position);
        }
        
        #endregion
        
        #region Local Position
        
        /// <summary>
        /// Sets the localPosition of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalPosition(this Transform transform, float x, float y, float z)
        {
            transform.localPosition = transform.localPosition.WithXYZ(x, y, z);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalPosition(this Transform transform, Vector3 position)
        {
            transform.localPosition = transform.localPosition.WithXYZ(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalPosition(this Transform transform, float position)
        {
            transform.localPosition = transform.localPosition.WithXYZ(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X value.
        /// </summary>
        public static void SetLocalPositionX(this Transform transform, float x)
        {
            transform.localPosition = transform.localPosition.WithX(x);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified Y value.
        /// </summary>
        public static void SetLocalPositionY(this Transform transform, float y)
        {
            transform.localPosition = transform.localPosition.WithY(y);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified Z value.
        /// </summary>
        public static void SetLocalPositionZ(this Transform transform, float z)
        {
            transform.localPosition = transform.localPosition.WithZ(z);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X and Y values.
        /// </summary>
        
        public static void SetLocalPositionXY(this Transform transform, float x, float y)
        {
            transform.localPosition = transform.localPosition.WithXY(x, y);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X and Y values.
        /// </summary>
        public static void SetLocalPositionXY(this Transform transform, Vector2 position)
        {
            transform.localPosition = transform.localPosition.WithXY(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X and Y values.
        /// </summary>
        public static void SetLocalPositionXY(this Transform transform, float position)
        {
            transform.localPosition = transform.localPosition.WithXY(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X and Z values.
        /// </summary>
        
        public static void SetLocalPositionXZ(this Transform transform, float x, float z)
        {
            transform.localPosition = transform.localPosition.WithXZ(x, z);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X and Z values.
        /// </summary>
        public static void SetLocalPositionXZ(this Transform transform, Vector2 position)
        {
            transform.localPosition = transform.localPosition.WithXZ(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified X and Z values.
        /// </summary>
        public static void SetLocalPositionXZ(this Transform transform, float position)
        {
            transform.localPosition = transform.localPosition.WithXZ(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified Y and Z values.
        /// </summary>
        
        public static void SetLocalPositionYZ(this Transform transform, float y, float z)
        {
            transform.localPosition = transform.localPosition.WithYZ(y, z);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalPositionYZ(this Transform transform, Vector2 position)
        {
            transform.localPosition = transform.localPosition.WithYZ(position);
        }

        /// <summary>
        /// Sets the localPosition of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalPositionYZ(this Transform transform, float position)
        {
            transform.localPosition = transform.localPosition.WithYZ(position);
        }
        
        #endregion
        
        #region Euler Angles

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetEulerAngles(this Transform transform, float x, float y, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithXYZ(x, y, z);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetEulerAngles(this Transform transform, Vector3 euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithXYZ(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetEulerAngles(this Transform transform, float euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithXYZ(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X value.
        /// </summary>
        public static void SetEulerAnglesX(this Transform transform, float x)
        {
            transform.eulerAngles = transform.eulerAngles.WithX(x);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified Y value.
        /// </summary>
        public static void SetEulerAnglesY(this Transform transform, float y)
        {
            transform.eulerAngles = transform.eulerAngles.WithY(y);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified Z value.
        /// </summary>
        public static void SetEulerAnglesZ(this Transform transform, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithZ(z);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X and Y values.
        /// </summary>
        
        public static void SetEulerAnglesXY(this Transform transform, float x, float y)
        {
            transform.eulerAngles = transform.eulerAngles.WithXY(x, y);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X and Y values.
        /// </summary>
        public static void SetEulerAnglesXY(this Transform transform, Vector2 euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithXY(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X and Y values.
        /// </summary>
        public static void SetEulerAnglesXY(this Transform transform, float euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithXY(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X and Z values.
        /// </summary>
        
        public static void SetEulerAnglesXZ(this Transform transform, float x, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithXZ(x, z);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X and Z values.
        /// </summary>
        public static void SetEulerAnglesXZ(this Transform transform, Vector2 euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithXZ(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified X and Z values.
        /// </summary>
        public static void SetEulerAnglesXZ(this Transform transform, float euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithXZ(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified Y and Z values.
        /// </summary>
        
        public static void SetEulerAnglesYZ(this Transform transform, float y, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithYZ(y, z);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetEulerAnglesYZ(this Transform transform, Vector2 euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithYZ(euler);
        }

        /// <summary>
        /// Sets the eulerAngles of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetEulerAnglesYZ(this Transform transform, float euler)
        {
            transform.eulerAngles = transform.eulerAngles.WithYZ(euler);
        }
        
        #endregion
        
        #region Local Euler Angles

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalEulerAngles(this Transform transform, float x, float y, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXYZ(x, y, z);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalEulerAngles(this Transform transform, Vector3 euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXYZ(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalEulerAngles(this Transform transform, float euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXYZ(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X value.
        /// </summary>
        public static void SetLocalEulerAnglesX(this Transform transform, float x)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithX(x);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified Y value.
        /// </summary>
        public static void SetLocalEulerAnglesY(this Transform transform, float y)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithY(y);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified Z value.
        /// </summary>
        public static void SetLocalEulerAnglesZ(this Transform transform, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithZ(z);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X and Y values.
        /// </summary>
        
        public static void SetLocalEulerAnglesXY(this Transform transform, float x, float y)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXY(x, y);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X and Y values.
        /// </summary>
        public static void SetLocalEulerAnglesXY(this Transform transform, Vector2 euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXY(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X and Y values.
        /// </summary>
        public static void SetLocalEulerAnglesXY(this Transform transform, float euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXY(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X and Z values.
        /// </summary>
        
        public static void SetLocalEulerAnglesXZ(this Transform transform, float x, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXZ(x, z);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X and Z values.
        /// </summary>
        public static void SetLocalEulerAnglesXZ(this Transform transform, Vector2 euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXZ(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified X and Z values.
        /// </summary>
        public static void SetLocalEulerAnglesXZ(this Transform transform, float euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXZ(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified Y and Z values.
        /// </summary>
        
        public static void SetLocalEulerAnglesYZ(this Transform transform, float y, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithYZ(y, z);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalEulerAnglesYZ(this Transform transform, Vector2 euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithYZ(euler);
        }

        /// <summary>
        /// Sets the localEulerAngles of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalEulerAnglesYZ(this Transform transform, float euler)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithYZ(euler);
        }
        
        #endregion
        
        #region Local Scale

        /// <summary>
        /// Sets the localScale of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalScale(this Transform transform, float x, float y, float z)
        {
            transform.localScale = transform.localScale.WithXYZ(x, y, z);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalScale(this Transform transform, Vector3 scale)
        {
            transform.localScale = transform.localScale.WithXYZ(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X, Y and Z values.
        /// </summary>
        public static void SetLocalScale(this Transform transform, float scale)
        {
            transform.localScale = transform.localScale.WithXYZ(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X value.
        /// </summary>
        public static void SetLocalScaleX(this Transform transform, float x)
        {
            transform.localScale = transform.localScale.WithX(x);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified Y value.
        /// </summary>
        public static void SetLocalScaleY(this Transform transform, float y)
        {
            transform.localScale = transform.localScale.WithY(y);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified Z value.
        /// </summary>
        public static void SetLocalScaleZ(this Transform transform, float z)
        {
            transform.localScale = transform.localScale.WithZ(z);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X and Y values.
        /// </summary>
        
        public static void SetLocalScaleXY(this Transform transform, float x, float y)
        {
            transform.localScale = transform.localScale.WithXY(x, y);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X and Y values.
        /// </summary>
        public static void SetLocalScaleXY(this Transform transform, Vector2 scale)
        {
            transform.localScale = transform.localScale.WithXY(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X and Y values.
        /// </summary>
        public static void SetLocalScaleXY(this Transform transform, float scale)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXY(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X and Z values.
        /// </summary>
        
        public static void SetLocalScaleXZ(this Transform transform, float x, float z)
        {
            transform.localScale = transform.localScale.WithXZ(x, z);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X and Z values.
        /// </summary>
        public static void SetLocalScaleXZ(this Transform transform, Vector2 scale)
        {
            transform.localScale = transform.localScale.WithXZ(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified X and Z values.
        /// </summary>
        public static void SetLocalScaleXZ(this Transform transform, float scale)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXZ(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalScaleYZ(this Transform transform, float y, float z)
        {
            transform.localScale = transform.localScale.WithYZ(y, z);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalScaleYZ(this Transform transform, Vector2 scale)
        {
            transform.localScale = transform.localScale.WithYZ(scale);
        }

        /// <summary>
        /// Sets the localScale of the Transform using specified Y and Z values.
        /// </summary>
        public static void SetLocalScaleYZ(this Transform transform, float scale)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithYZ(scale);
        }
        
        #endregion
    }
}