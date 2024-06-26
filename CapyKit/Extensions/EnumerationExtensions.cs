﻿using CapyKit.Attributes;
using CapyKit.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Extensions
{
    /// <summary> Provides static extentions methods for providing additional functionality for <see cref="Enum"/> types. </summary>
    public static class EnumerationExtensions
    {
        #region Methods

        /// <summary>
        /// A <typeparamref name="T"/> extension method that parses a string into an enumeration.
        /// </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="enumeration"> The enumeration to act on. </param>
        /// <param name="value">       The value. </param>
        /// <returns> A T. </returns>
        public static T Parse<T>(this T enumeration, string value) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        /// <summary>
        /// A <typeparamref name="T"/> extension method that parses a string into an enumeration.
        /// </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="enumeration"> The enumeration to act on. </param>
        /// <param name="value">       The string value of the <see cref="Enum"/>. </param>
        /// <param name="ignoreCase">  True to ignore case. </param>
        /// <returns> A T. </returns>
        public static T Parse<T>(this T enumeration, string value, bool ignoreCase) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }

        /// <summary>
        /// An <see cref="Enum"/> extension method that gets an integer value representing the enumation.
        /// </summary>
        /// <param name="enumeration"> The enumeration to act on. </param>
        /// <returns> The integer value of the enumeration. </returns>
        public static int GetValue(this Enum enumeration)
        {
            return (int)Convert.ChangeType(enumeration, TypeCode.Int32);
        }

        /// <summary> An <see cref="Enum"/> extension method that gets a name. </summary>
        /// <param name="enumeration"> The enumeration to act on. </param>
        /// <returns> The name of the enumeration. </returns>
        public static string GetName(this Enum enumeration)
        {
            return Enum.GetName(enumeration.GetType(), enumeration) ?? "[Unknown]";
        }

        /// <summary> An <see cref="Enum"/> extension method that gets a human readable name. </summary>
        /// <param name="enumeration"> The enumeration to act on. </param>
        /// <returns> The human readable name of the enumeration. </returns>
        public static string GetPrettyName(this Enum enumeration)
        {
            return LanguageHelper.CamelCaseToHumanReadable(GetName(enumeration));
        }

        /// <summary> An <see cref="Enum"/> extension method that gets a description. </summary>
        /// <param name="enumeration"> The enumeration to act on. </param>
        /// <returns>
        /// The description if available, otherwise the string representation of the enumeration.
        /// </returns>
        public static string GetDescription(this Enum enumeration)
        {
            var memInfo = enumeration.GetType().GetMember(enumeration.GetName());
            if (memInfo.Any())
            {
                var attribute = memInfo.First().GetCustomAttribute(typeof(EnumerationDescriptionAttribute)) as EnumerationDescriptionAttribute;
                if (attribute == null)
                {
                    CapyEventReporter.EmitEvent(EventLevel.Error, "Could not find the description for {0}.", args: new[] { enumeration });
                }
                else
                {
                    return attribute.Value;
                }
            }

            return enumeration.ToString();
        }

        #endregion Methods
    }
}
