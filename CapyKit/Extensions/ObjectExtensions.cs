using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Extensions
{
    /// <summary> An class containing extenstions that apply to any object type. </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// An object extension method that updates the properties of a given <paramref name="target"/>
        /// object with the values from a given <paramref name="source"/> object.
        /// </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="target"> The target object to act on. </param>
        /// <param name="source"> Source for the new property values. </param>
        public static void UpdateProperties<T>(this T target, T source)
        {
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                if (prop.CanWrite)
                {
                    prop.SetValue(target, prop.GetValue(source));
                }
            }
        }

        /// <summary>
        /// An object extension method that updates the properties of a given <paramref name="target"/>
        /// object with the values from a given <paramref name="source"/> object.
        /// </summary>
        /// <param name="target"> The target object to act on. </param>
        /// <param name="source"> Source for the new property values. </param>
        public static void UpdateProperties(this object target, object source)
        {
            var targetProperties = target.GetType().GetProperties();
            var sourceProperties = source.GetType().GetProperties();
            var matchingProperties = targetProperties.Join(sourceProperties, outer => new { outer.Name, outer.PropertyType }, inner => new { inner.Name, inner.PropertyType }, (outer, inner) => new { Target = outer, Source = inner });

            foreach (var propertyMatch in matchingProperties)
            {
                if(propertyMatch.Target.CanWrite)
                {
                    propertyMatch.Target.SetValue(target, propertyMatch.Source.GetValue(source));
                }
            }
        }
    }
}
