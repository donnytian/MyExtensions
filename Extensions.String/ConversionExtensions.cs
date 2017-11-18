﻿using System;
using System.Text;

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
        /// <returns><see cref="float"/> value if conversion succeeded; otherwise 0.</returns>
        public static float ToSingle(this string value)
        {
            float.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="double"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns><see cref="double"/> value if conversion succeeded; otherwise 0.</returns>
        public static double ToDouble(this string value)
        {
            double.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a number to its <see cref="decimal"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a number to convert </param>
        /// <returns>Decimal value if conversion succeeded; otherwise 0.</returns>
        public static decimal ToDecimal(this string value)
        {
            decimal.TryParse(value, out var number);

            return number;
        }

        /// <summary>
        /// Converts the string representation of a value to its <see cref="bool"/> equivalent.
        /// </summary>
        /// <param name="value">The string containing a boolean to convert </param>
        /// <returns>Boolean value if conversion succeeded; otherwise false.</returns>
        public static bool ToBool(this string value)
        {
            bool.TryParse(value, out var b);

            return b;
        }

        /// <summary>
        /// Converts the string to a byte array.
        /// </summary>
        /// <param name="value">The string to convert </param>
        /// <returns>Byte array.</returns>
        public static byte[] ToBytes(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return new byte[0];
            }

            var bytes = new byte[value.Length * sizeof(char)];
            Buffer.BlockCopy(value.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// Converts the string to a byte array.
        /// </summary>
        /// <param name="value">The string to convert </param>
        /// <param name="encoding">The encoding to use</param>
        /// <returns>Byte array.</returns>
        public static byte[] ToBytes(this string value, Encoding encoding)
        {
            if (string.IsNullOrEmpty(value))
            {
                return new byte[0];
            }

            if (encoding == null)
            {
                return ToBytes(value);
            }

            return encoding.GetBytes(value);
        }
    }
}
