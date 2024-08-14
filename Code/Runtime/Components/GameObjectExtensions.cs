using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Checks if the game object has a component of the specified type.
        /// </summary>
        public static bool HasComponent<T>(this GameObject gameObject) 
            where T : Component
        {
            return gameObject.TryGetComponent<T>(out _);
        }
        
        /// <summary>
        /// Checks if the game object has a component of the specified type.
        /// </summary>
        public static bool HasComponent(this GameObject gameObject, Type type)
        {
            return gameObject.TryGetComponent(type, out _);
        }
        
        /// <summary>
        /// Returns the component of type T attached to the game object, or adds a new one if none exists.
        /// </summary>
        public static T GetOrAddComponent<T>(this GameObject gameObject) 
            where T : Component
        {
            return gameObject.TryGetComponent<T>(out var component) 
                ? component 
                : gameObject.AddComponent<T>();
        }
        
        /// <summary>
        /// Returns the component of the specified type attached to the game object, or adds a new one if none exists.
        /// </summary>
        public static Component GetOrAddComponent(this GameObject gameObject, Type type)
        {
            return gameObject.TryGetComponent(out Component component) 
                ? component 
                : gameObject.AddComponent(type);
        }
        
        /// <summary>
        /// Attempts to get the component of type T in the child objects.
        /// </summary>
        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component, bool includeInactive = false) 
            where T : Component
        {
            return component = gameObject.GetComponentInChildren<T>(includeInactive);
        }
        
        /// <summary>
        /// Attempts to get the component of the specified type in the child objects.
        /// </summary>
        public static bool TryGetComponentInChildren(this GameObject gameObject, Type type, out Component component, 
            bool includeInactive = false)
        {
            return component = gameObject.GetComponentInChildren(type, includeInactive);
        }
        
        /// <summary>
        /// Attempts to get the component of type T in the parent object.
        /// </summary>
        public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T component, bool includeInactive = false) 
            where T : Component
        {
            return component = gameObject.GetComponentInParent<T>(includeInactive);
        }
        
        /// <summary>
        /// Attempts to get the component of the specified type in the parent object.
        /// </summary>
        public static bool TryGetComponentInParent(this GameObject gameObject, Type type, out Component component, 
            bool includeInactive = false)
        {
            return component = gameObject.GetComponentInParent(type, includeInactive);
        }
        
        /// <summary>
        /// Set the enabled MonoBehaviour of type <c>T</c>, if it exists.
        /// </summary>
        public static bool EnableComponentIfExists<T>(this GameObject gameObject, bool enable = true) 
            where T : MonoBehaviour
        {
            if (!gameObject.TryGetComponent<T>(out var component)) return false;
            
            component.enabled = enable;
            
            return true;
        }
        
        /// <summary>
        /// Set the enabled MonoBehaviour of declared <c>type</c>, if it exists.
        /// </summary>
        public static bool EnableComponentIfExists(this GameObject gameObject, Type type, bool enable = true)
        {
            if (!gameObject.TryGetComponent(type, out var component)) return false;
            if (component is not MonoBehaviour monoBehaviour) return false;
            
            monoBehaviour.enabled = enable;
            
            return true;
        }
        
        /// <summary>
        /// Performs an action on all children of a specific type.
        /// </summary>
        public static void ForEachComponentInChildren<T>(this GameObject gameObject, Action<T> action, bool includeInactive = false) 
            where T : Component
        {
            if (action == null) return;
            
            foreach (var component in gameObject.GetComponentsInChildren<T>(includeInactive))
            {
                action.Invoke(component);
            }
        }

        /// <summary>
        /// Searches for all child elements that match the predicate.
        /// </summary>
        public static IEnumerable<Transform> FindChildrenRecursive(this GameObject gameObject, Predicate<Transform> predicate)
        {
            foreach (Transform child in gameObject.transform)
            {
                if (predicate.Invoke(child))
                {
                    yield return child;
                }

                foreach (var grandChild in child.gameObject.FindChildrenRecursive(predicate))
                {
                    yield return grandChild;
                }
            }
        }

        /// <summary>
        /// Sets the layer for all child elements.
        /// </summary>
        public static void SetLayerForAllChildren(this GameObject gameObject, int layer)
        {
            SetLayerRecursive(gameObject.transform, layer);
            
            return;
            
            static void SetLayerRecursive(Transform transform, int layer)
            {
                transform.gameObject.layer = layer;
                
                foreach (Transform o in transform)
                {
                    SetLayerRecursive(o, layer);
                }
            }
        }
    }
}