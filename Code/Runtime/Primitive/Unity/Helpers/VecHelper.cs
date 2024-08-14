using System;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public enum Vec2Axis
    {
        X,
        Y,
    }
    
    [PublicAPI]
    public enum Vec3Axis
    {
        X,
        Y,
        Z,
    }
    
    [PublicAPI]
    public enum Vec4Axis
    {
        X,
        Y,
        Z,
        W,
    }
    
    internal static class VecHelper
    {
        private const string INCORRECT_AXIS_ERROR_MESSAGE = "The axis value is not one of the available values.";
        
        public static float GetValueFromAxis(in this Vector2 vector, Vec2Axis axis)
        {
            return axis switch
            {
                Vec2Axis.X => vector[0],
                Vec2Axis.Y => vector[1],
                _ => throw new ArgumentException(INCORRECT_AXIS_ERROR_MESSAGE)
            };
        }
        
        public static int GetValueFromAxis(in this Vector2Int vector, Vec2Axis axis)
        {
            return axis switch
            {
                Vec2Axis.X => vector[0],
                Vec2Axis.Y => vector[1],
                _ => throw new ArgumentException(INCORRECT_AXIS_ERROR_MESSAGE)
            };
        }
        
        public static float GetValueFromAxis(in this Vector3 vector, Vec3Axis axis)
        {
            return axis switch
            {
                Vec3Axis.X => vector[0],
                Vec3Axis.Y => vector[1],
                Vec3Axis.Z => vector[2],
                _ => throw new ArgumentException(INCORRECT_AXIS_ERROR_MESSAGE)
            };
        }
        
        public static int GetValueFromAxis(in this Vector3Int vector, Vec3Axis axis)
        {
            return axis switch
            {
                Vec3Axis.X => vector[0],
                Vec3Axis.Y => vector[1],
                Vec3Axis.Z => vector[2],
                _ => throw new ArgumentException(INCORRECT_AXIS_ERROR_MESSAGE)
            };
        }
        
        public static float GetValueFromAxis(in this Vector4 vector, Vec4Axis axis)
        {
            return axis switch
            {
                Vec4Axis.X => vector[0],
                Vec4Axis.Y => vector[1],
                Vec4Axis.Z => vector[2],
                Vec4Axis.W => vector[3],
                _ => throw new ArgumentException(INCORRECT_AXIS_ERROR_MESSAGE)
            };
        }
    }
}