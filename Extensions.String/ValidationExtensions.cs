using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions.String
{
    /// <summary>
    /// Provides validation extensions for <see cref="string"/> class.
    /// </summary>
    public static class ValidationExtensions
    {
        /// <summary>
        /// Checks whether the given sub-string can be located within the input string.
        /// </summary>
        /// <param name="s">The input string to be checked.</param>
        /// <param name="subString">The sub-string to be searched.</param>
        /// <param name="comparsonType">The string comparison type.</param>
        /// <returns>True if sub-string found; otherwise false.</returns>
        public static bool Contains(this string s, string subString, StringComparison comparsonType)
        {
            if (s == null || subString == null)
            {
                return false;
            }

            var index = s.IndexOf(subString, comparsonType);

            return index >= 0;
        }

        /// <summary>
        /// Checks whether the given sub-string can be located within the input string.
        /// </summary>
        /// <param name="enumerable">The input strings to be checked.</param>
        /// <param name="value">The sub-string to be searched.</param>
        /// <param name="comparsonType">The string comparison type.</param>
        /// <returns>True if sub-string found; otherwise false.</returns>
        public static bool Contains(this IEnumerable<string> enumerable, string value, StringComparison comparsonType)
        {
            if (enumerable == null)
            {
                return false;
            }

            return enumerable.Any(s => string.Compare(s, value, comparsonType) == 0);
        }

        /// <summary>
        /// Indicates whether the specified string is null or an <see cref="F:System.String.Empty" /> string.
        /// </summary>
        /// <param name="s">The string to test. </param>
        /// <returns>true if the <paramref name="s" /> parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="s">The string to test.</param>
        /// <returns>true if the <paramref name="s" /> parameter is null or <see cref="F:System.String.Empty" />, or if <paramref name="s" /> consists exclusively of white-space characters. </returns>
        public static bool IsNullOrWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s);

        /*
         * IsInteger
         * IsNumeric
         * IsAlpha
         * IsAlphaNumeric
         * IsValidIPv4
         * IsEmailAddress
         * IsDateTime
         */
    }
}
