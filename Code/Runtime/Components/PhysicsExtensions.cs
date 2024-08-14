using System;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class PhysicsExtensions
    {
        /// <summary>
        /// Returns all components of the passed type within the given radius.
        /// </summary>
        public static T[] GetComponentsInRadius<T>(this Transform transform, float radius)
            where T : Component
        {
            return GetComponentsInRadius<T>(transform.position, radius);
        }
        
        /// <summary>
        /// Returns all components of the passed type within the given radius.
        /// </summary>
        public static T[] GetComponentsInRadius<T>(this Vector3 center, float radius) 
            where T : Component
        {
            var colliders = Array.Empty<Collider>();
            var count = Physics.OverlapSphereNonAlloc(center, radius, colliders);
            
            if (count == 0) return Array.Empty<T>();
            
            return colliders
                .Select(t => t.GetComponent<T>())
                .Where(t => t)
                .ToArray();
        }
    }
}