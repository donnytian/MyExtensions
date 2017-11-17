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
    }
}
