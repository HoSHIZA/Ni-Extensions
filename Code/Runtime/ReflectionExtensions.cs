using System;
using System.Reflection;
using JetBrains.Annotations;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class ReflectionExtensions
    {
        /// <summary>
        /// Returns the value of a field or property from the passed object, using reflection.
        /// </summary>
        public static object GetValue(this MemberInfo member, object target = null) => member switch
        {
            FieldInfo field => field.GetValue(target),
            PropertyInfo property => property.GetValue(target),
            _ => throw new ArgumentOutOfRangeException(nameof(member), member, "Unsupported type!")
        };
        
        /// <summary>
        /// Sets a value in a field or property of the passed object using reflection.
        /// </summary>
        public static void SetValue(this MemberInfo member, object value, object target = null)
        {
            switch (member)
            {
                case FieldInfo field: field.SetValue(target, value); break;
                case PropertyInfo property: property.SetValue(target, value); break;
            }
        }
    }
}