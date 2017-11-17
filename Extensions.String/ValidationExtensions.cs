using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
