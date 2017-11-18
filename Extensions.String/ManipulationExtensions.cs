using System;

namespace Extensions.String
{
    /// <summary>
    /// Provides manipulation extensions for <see cref="string"/> class.
    /// </summary>
    public static class ManipulationExtensions
    {
        /// <summary>
        /// Gets a truncated string based on the input.
        /// </summary>
        /// <param name="s">The string to be truncated.</param>
        /// <param name="maxLength">The maximum length of the result string. Not included suffix.</param>
        /// <param name="suffix">The suffix of the result string if there is any character(s) truncated.</param>
        /// <returns>The truncated string.</returns>
        public static string Truncate(this string s, int maxLength, string suffix = "")
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return s.Length <= maxLength ? s : s.Substring(0, maxLength) + suffix;
        }

        /// <summary>
        /// Reverses all characters in input string.
        /// </summary>
        /// <param name="s">The input string to reverse</param>
        /// <returns>A reversed version from input</returns>
        public static string Reverse(this string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : Reverse(s, 0, s.Length);
        }

        /// <summary>
        /// Reverses all characters in input within the range from startIndex till length
        /// </summary>
        /// <param name="s">The input string to reverse</param>
        /// <param name="startIndex">The startIndex startIndex of the input string to begin reversing</param>
        /// <param name="count">The amount of characters to reverse</param>
        /// <returns>A reversed version from input</returns>
        public static string Reverse(this string s, int startIndex, int count)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex >= s.Length - 1)
            {
                return s;
            }

            if (count > s.Length - startIndex)
            {
                count = s.Length - startIndex;
            }

            if (count <= 1)
            {
                return s;
            }

            var characters = s.ToCharArray();

            Array.Reverse(characters, startIndex, count);

            return new string(characters);
        }

        /*
         * EncodeAs(Encoding)
         * Right(int), RightOf(string, int=0)
         * Left(int), LeftOf(string, int=0)
         * TrimStart(string, StringComparison, int=0)
         * TrimEnd(string, StringComparison, int=0)
         */
    }
}
