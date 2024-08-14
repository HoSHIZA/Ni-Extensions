using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class ObjectExtensions
    {
        /// <summary>
        /// Creates a deep copy of an object, including public and private fields, as well as nested objects.
        /// </summary>
        public static T DeepClone<T>(this T @this)
        {
            const BindingFlags bindingAttr = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            
            if (@this == null) return default;
            
            var type = @this.GetType();
            
            if (type.IsPrimitive || type == typeof(string)) return @this;

            var clone = Activator.CreateInstance(type);
            var fields = type.GetFields(bindingAttr);
            
            foreach (var field in fields)
            {
                var fieldValue = field.GetValue(@this);
                if (fieldValue != null)
                {
                    field.SetValue(clone, DeepClone(fieldValue));
                }
            }
            
            return (T)clone;
        }
        
#if !NIEXTENSIONS_DISABLE_MONAD
        #region With/When/If

        /// <summary>
        /// Performs an action on an object and returns it.
        /// </summary>
        public static T With<T>(this T @this, Action<T> action)
        {
            action?.Invoke(@this);
            return @this;
        }
        
        /// <summary>
        /// Performs the action if the condition is true.
        /// </summary>
        public static T WhenTrue<T>(this T @this, bool condition, Action<T> action)
        {
            if (condition) action?.Invoke(@this);
            return @this;
        }

        /// <summary>
        /// Performs the action if the condition is false.
        /// </summary>
        public static T WhenFalse<T>(this T @this, bool condition, Action<T> action)
        {
            if (!condition) action?.Invoke(@this);
            return @this;
        }

        /// <summary>
        /// Performs an action on an object if it satisfies the predicate.
        /// </summary>
        public static T If<T>(this T @this, Predicate<T> predicate, Action<T> action)
        {
            if (predicate.Invoke(@this)) action?.Invoke(@this);
            return @this;
        }

        /// <summary>
        /// Performs an action on the object if it does not satisfy the predicate.
        /// </summary>
        public static T IfNot<T>(this T @this, Predicate<T> predicate, Action<T> action)
        {
            if (!predicate.Invoke(@this)) action?.Invoke(@this);
            return @this;
        }

        /// <summary>
        /// Performs an action if the object is not null.
        /// </summary>
        public static T IfNull<T>(this T @this, Action action) 
            where T : class
        {
            if (@this == null) action?.Invoke();
            return @this;
        }

        /// <summary>
        /// Performs an action if the object is not null.
        /// </summary>
        public static T IfNotNull<T>(this T @this, Action<T> action) 
            where T : class
        {
            if (@this != null) action?.Invoke(@this);
            return @this;
        }

        /// <summary>
        /// Performs an action depending on the result of the predicate.
        /// </summary>
        public static TResult Match<T, TResult>(this T @this, Predicate<T> predicate, Func<T, TResult> trueAction, Func<T, TResult> falseAction)
        {
            return predicate.Invoke(@this) ? trueAction.Invoke(@this) : falseAction.Invoke(@this);
        }

        #endregion

        #region Throw

        /// <summary>
        /// Throws an exception if the value is null.
        /// </summary>
        public static T ThrowIf<T>(this T @this, Predicate<T> predicate, [CallerMemberName] string paramName = "")
        {
            return predicate.Invoke(@this) ? throw new ArgumentNullException(paramName) : @this;
        }

        /// <summary>
        /// Throws an exception if the value is true.
        /// </summary>
        public static T ThrowIfTrue<T>(this T @this, bool condition, [CallerMemberName] string paramName = "")
        {
            return condition ? throw new ArgumentNullException(paramName) : @this;
        }

        /// <summary>
        /// Throws an exception if the value is false.
        /// </summary>
        public static T ThrowIfFalse<T>(this T @this, bool condition, [CallerMemberName] string paramName = "")
        {
            return condition ? @this : throw new ArgumentNullException(paramName);
        }
        
        /// <summary>
        /// Throws an exception if the value is not null.
        /// </summary>
        public static T ThrowIfNull<T>(this T @this, string paramName = "")
            where T : class
        {
            return @this ?? throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Throws an exception if the value is default.
        /// </summary>
        public static T ThrowIfDefault<T>(this T @this, [CallerMemberName] string paramName = "")
            where T : struct
        {
            return EqualityComparer<T>.Default.Equals(@this, default) ? throw new ArgumentNullException(paramName) : @this;
        }

        #endregion

        #region Map

        /// <summary>
        /// Applies a function to an object and returns the result.
        /// </summary>
        public static TResult Map<T, TResult>(this T @this, Func<T, TResult> func)
        {
            return func.Invoke(@this);
        }
        
        /// <summary>
        /// Applies the function to the object and returns the result if it matches the predicate.
        /// </summary>
        public static TResult MapIf<T, TResult>(this T @this, Func<T, TResult> func, Predicate<T> predicate)
        {
            return predicate.Invoke(@this) ? func.Invoke(@this) : default;
        }
        
        /// <summary>
        /// Applies the function to the object and returns the result if true.
        /// </summary>
        public static TResult MapIfTrue<T, TResult>(this T @this, bool condition, Func<T, TResult> func)
        {
            return condition ? func.Invoke(@this) : default;
        }
        
        /// <summary>
        /// Applies the function to the object and returns the result if false.
        /// </summary>
        public static TResult MapIfFalse<T, TResult>(this T @this, bool condition, Func<T, TResult> func)
        {
            return condition ? default : func.Invoke(@this);
        }
        
        /// <summary>
        /// Applies the function to the object and returns result if it is not null.
        /// </summary>
        public static TResult MapIfNotNull<T, TResult>(this T @this, Func<T, TResult> func)
            where T : class
        {
            return @this != null ? func.Invoke(@this) : default;
        }
        
        /// <summary>
        /// Applies the function to the object and returns result if it is not default.
        /// </summary>
        public static TResult MapIfNotDefault<T, TResult>(this T @this, Func<T, TResult> func)
            where T : struct
        {
            return EqualityComparer<T>.Default.Equals(@this, default) ? default : func.Invoke(@this);
        }
        
        #endregion
        
        #region Convert
        
        private static object[] _cachedConvertParameter;
        
        /// <summary>
        /// Converts the object to another type, if possible.
        /// </summary>
        public static TResult As<T, TResult>(this T @this) 
            where TResult : class
        {
            return @this as TResult;
        }
        
        /// <summary>
        /// Converts the object to another type.
        /// </summary>
        public static T Cast<T>(this object @this)
        {
            return (T)@this;
        }
        
        /// <summary>
        /// Converts the object to another type.
        /// Writes the result to the <c>result</c> parameter and returns true if the conversion succeeded.
        /// </summary>
        public static bool TryCast<T>(this object obj, out T result) 
            where T : class
        {
            result = obj as T;
            return result != null;
        }
        
        /// <summary>
        /// Converts the object to another type, if possible.
        /// </summary>
        public static T To<T>(this object @this) 
        {
            switch (@this)
            {
                case null:          return default;
                case T objT:        return objT;
                case IConvertible:  return (T)Convert.ChangeType(@this, typeof(T));
            }

            var objType = @this.GetType();
            
            var method = objType
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(t => t.Name is "op_Implicit" or "op_Explicit" && t.ReturnType == typeof(T));
            
            if (method != null)
            {
                _cachedConvertParameter ??= new object[1];
                _cachedConvertParameter[0] = @this;
                
                return (T)method.Invoke(null, _cachedConvertParameter);
            }
            
            return default;
        }

        #endregion

        #region TryCatch

        /// <summary>
        /// Performs an action with exception handling.
        /// </summary>
        public static T TryCatch<T>(this T @this, Action<T> action, Action<Exception> exceptionHandler)
        {
            try
            {
                action?.Invoke(@this);
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
            }
            return @this;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// Performs an action for each item in the collection.
        /// </summary>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            var arr = @this.ToArray();
            foreach (var item in arr)
            {
                action?.Invoke(item);
            }
            return arr;
        }

        #endregion
#endif
    }
}
