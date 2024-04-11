using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Attributes
{
    /// <summary>
    /// Custom attribute class for decorating enumeration fields with additional data.
    /// </summary>
    /// <typeparam name="T">
    ///     Generic type parameter allowing for arbitrary declarations and assignments of meaning.
    /// </typeparam>
    [AttributeUsage(AttributeTargets.Field)]
    public abstract class EnumerationAttribute<T> : Attribute
    {
        #region Properties

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationAttribute{T}"/> class with a
        /// specified value.
        /// </summary>
        /// <value> The value. </value>
        public T Value { get; private set; }

        #endregion

        #region Constructors

        /// <summary> Gets the value of the enumeration represented by this attribute. </summary>
        /// <param name="value">
        ///     Initializes a new instance of the <see cref="EnumerationAttribute{T}"/> class with a
        ///     specified value.
        /// </param>
        protected EnumerationAttribute(T value)
        {
            this.Value = value;
        }

        #endregion
    }
}
