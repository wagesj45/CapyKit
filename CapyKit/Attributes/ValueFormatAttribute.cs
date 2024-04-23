using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Attributes
{
    /// <summary>
    /// Custom attribute for formatting values in a specific way.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ValueFormatAttribute : Attribute
    {
        #region Properties

        /// <summary> Gets or sets the format to use for formatting the value. </summary>
        /// <value> The format string used to format the value. </value>
        public string Format { get; private set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Default constructor. Initializes a new instance of the <see cref="ValueFormatAttribute"/>
        /// class with an empty format string.
        /// </summary>
        public ValueFormatAttribute()
        {
            this.Format = string.Empty;
        }

        /// <summary>
        /// Constructor. Initializes a new instance of the <see cref="ValueFormatAttribute"/> class with
        /// the specified format string.
        /// </summary>
        /// <param name="format"> The format string used to format the value. </param>
        public ValueFormatAttribute(string format)
        {
            this.Format = format;
        }

        #endregion Constructors

        #region Methods

        /// <summary> Gets a parameterized formatted string for the specified index. </summary>
        /// <param name="index"> (Optional) Zero-based index of the item in the string to format. </param>
        /// <returns> A formatted string with the specified index and format. </returns>
        public string GetFormatParameterizedString(int index = 0)
        {
            return "{" + index + ":" + this.Format + "}";
        }

        #endregion Methods
    }
}
