namespace Extensions.String
{
    /// <summary>
    /// Provides conversion extensions for <see cref="string"/> class.
    /// </summary>
    public static class ConversionExtensions
    {
        /// <summary>
        /// Converts the string representation of a number to its <see cref="short"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Int16 value if conversion succeeded; otherwise 0.</returns>
        public static short ToInt16(this string value)
        {
            short.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="int"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Int32 value if conversion succeeded; otherwise 0.</returns>
        public static int ToInt32(this string value)
        {
            int.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="long"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Int64 value if conversion succeeded; otherwise 0.</returns>
        public static long ToInt64(this string value)
        {
            long.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="float"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Int64 value if conversion succeeded; otherwise 0.</returns>
        public static float ToSingle(this string value)
        {
            float.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="double"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Int64 value if conversion succeeded; otherwise 0.</returns>
        public static double ToDouble(this string value)
        {
            double.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="decimal"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Int64 value if conversion succeeded; otherwise 0.</returns>
        public static decimal ToDecimal(this string value)
        {
            decimal.TryParse(value, out var number);

            return number;
        }
    }
}
