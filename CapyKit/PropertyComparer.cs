using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit
{
    /// <summary>
    /// A object comparer that can accept a lambda expression to compare properties.
    /// </summary>
    /// <typeparam name="T"> Generic type parameter of the parent object. </typeparam>
    /// <typeparam name="U"> Generic type parameter of the property value. </typeparam>
    /// <example>
    ///  using System;
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// 
    /// class Program
    /// {
    ///     static void Main(string[] args)
    ///     {
    ///         var people = new List&lt;Person&gt;
    ///     {
    ///         new Person { Name = "Alice", Age = 30 }, new Person { Name = "Bob", Age = 30 }, new
    ///         Person { Name = "Charlie", Age = 35 }
    ///     };
    /// 
    ///         var comparer = new PropertyComparer&lt;Person, int&gt;(p =&gt; p.Age);
    ///         var distinctPeople = people.Distinct(comparer).ToList();
    /// 
    ///         foreach (var person in distinctPeople)
    ///         {
    ///             Console.WriteLine($"{person.Name} - {person.Age}");
    ///         }
    ///     }
    /// }
    /// 
    /// class Person
    /// {
    ///     public string Name { get; set; }
    ///     public int Age { get; set; }
    /// }
    /// </example>
    public class PropertyComparer<T, U> : IEqualityComparer<T>
    {
        /// <summary> The expression to retrieve the property. </summary>
        private Func<T, U> expression;

        /// <summary> Constructor. </summary>
        /// <param name="expression"> The expression. </param>
        public PropertyComparer(Func<T, U> expression)
        {
            this.expression = expression;
        }

        /// <summary> Determines whether the specified properties are equal. </summary>
        /// <param name="x"> The first object of type <typeparamref name="T"/> to compare. </param>
        /// <param name="y"> The second object of type <typeparamref name="T" /> to compare. </param>
        /// <returns>
        /// <see langword="true" /> if the specified objects are equal; otherwise,
        /// <see langword="false" />.
        /// </returns>
        public bool Equals(T x, T y)
        {
            var left = expression.Invoke(x);
            var right = expression.Invoke(y);

            if (left == null && right == null)
            {
                return true;
            }
            if (left == null ^ right == null)
            {
                return false;
            }
            else
            {
                return left.Equals(right);
            }
        }

        /// <summary> Returns a hash code for the specified object. </summary>
        /// <param name="obj">
        ///     The <see cref="T:System.Object" /> for which a hash code is to be returned.
        /// </param>
        /// <returns> A hash code for the specified object. </returns>
        ///
        /// ### <exception cref="T:System.ArgumentNullException">
        ///     The type of <paramref name="obj" /> is a reference type and
        ///     <paramref name="obj" /> is
        ///     <see langword="null" />.
        /// </exception>
        public int GetHashCode(T obj)
        {
            var property = expression(obj);

            return (property == null) ? 0 : property.GetHashCode();
        }
    }
}
