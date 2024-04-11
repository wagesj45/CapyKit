using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Attributes
{
    /// <summary> An attribute class for decorating enumeration fields with a description. </summary>
    /// <seealso cref="EnumerationAttribute{T}"/>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumerationDescriptionAttribute : EnumerationAttribute<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerationDescriptionAttribute"/> class with
        /// the specified description.
        /// </summary>
        /// <param name="description"> The description of the enumeration value. </param>
        public EnumerationDescriptionAttribute(string description)
            : base(description)
        {
            //
        }
    }
}
