using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Extensions
{
    /// <summary> Provides static extentions methods for providing additional functionality for <see cref="string"/> types. </summary>
    public static class StringExtensions
    {
        #region Members

        //

        #endregion Members

        #region Methods

        /// <summary> Replaces a null or empty string with a specified replacement string. </summary>
        /// <param name="value">       The original string. </param>
        /// <param name="replacement"> The replacement string. </param>
        /// <returns>
        /// The original string if not null or empty, otherwise the replacement string.
        /// </returns>
        /// <seealso cref="string.IsNullOrEmpty(string?)"/>
        public static string IfNullOrEmpty(this string value, string replacement)
        {
            if (string.IsNullOrEmpty(value))
            {
                return replacement;
            }

            return value;
        }

        /// <summary> Replaces a null or whitespace string with a specified replacement string. </summary>
        /// <param name="value">       The original string. </param>
        /// <param name="replacement"> The replacement string. </param>
        /// <returns>
        /// The original string if not null or whitespace, otherwise the replacement string.
        /// </returns>
        /// <seealso cref="string.IsNullOrWhiteSpace(string?)"/>
        public static string IfNullOrWhiteSpace(this string value, string replacement)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return replacement;
            }

            return value;
        }

        #endregion Methods
    }
}
