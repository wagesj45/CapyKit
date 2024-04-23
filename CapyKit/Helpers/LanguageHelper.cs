using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    /// <summary>
    /// Helper class for handling text transformations.
    /// </summary>
    public class LanguageHelper
    {
        #region Methods

        /// <summary> Converts camel case text to human readable text. </summary>
        /// <remarks>
        /// Camel case is a naming convention for identifiers in which the first letter of each word is
        /// capitalized.
        /// </remarks>
        /// <param name="value"> The value. </param>
        /// <returns> A string in human readable format. </returns>
        public static string CamelCaseToHumanReadable(string value)
        {
            var regex = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) | (?<=[^A-Z])(?=[A-Z]) | (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            return regex.Replace(value, " ");
        } 

        #endregion
    }
}
