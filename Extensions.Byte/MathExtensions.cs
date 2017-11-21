using System;
using System.Linq;

namespace Extensions.Byte
{
    /// <summary>
    /// Provides math extensions for <see cref="byte"/> class.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Gets the bitwise NOT result.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <returns>The bitwise NOT result bytes.</returns>
        public static byte[] Not(this byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            return bytes.Select(b => (byte)~b).ToArray();
        }

        /// <summary>
        /// Gets the bitwise AND result.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>The bitwise AND result bytes.</returns>
        public static byte[] And(this byte[] bytes, byte[] another)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            if (another == null)
            {
                throw new ArgumentNullException(nameof(another));
            }

            return bytes.Zip(another, (a, b) => (byte)(a & b)).ToArray();
        }

        /// <summary>
        /// Gets the bitwise OR result.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>The bitwise OR result bytes.</returns>
        public static byte[] Or(this byte[] bytes, byte[] another)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            if (another == null)
            {
                throw new ArgumentNullException(nameof(another));
            }

            return bytes.Zip(another, (a, b) => (byte)(a | b)).ToArray();
        }

        /// <summary>
        /// Checks if the number from given bytes is greater than another number.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>True if it's greater; otherwise false.</returns>
        public static bool GreaterThan(this byte[] bytes, byte[] another)
        {
            return bytes.CompareTo(another) > 0;
        }

        /// <summary>
        /// Checks if the number from given bytes is greater or equals to another number.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>True if it's greater or equal; otherwise false.</returns>
        public static bool GreaterOrEqual(this byte[] bytes, byte[] another)
        {
            return bytes.CompareTo(another) >= 0;
        }

        /// <summary>
        /// Checks if the number from given bytes is less or equals to another number.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>True if it's less or equal; otherwise false.</returns>
        public static bool LessOrEqual(this byte[] bytes, byte[] another)
        {
            return bytes.CompareTo(another) <= 0;
        }

        /// <summary>
        /// Checks if the number from given bytes is less than another number.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>True if it's less; otherwise false.</returns>
        public static bool LessThan(this byte[] bytes, byte[] another)
        {
            return bytes.CompareTo(another) < 0;
        }

        /// <summary>
        /// Checks if the number that represented by the given bytes is equal to another number.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>True if it's equal; otherwise false.</returns>
        public static bool EqualsTo(this byte[] bytes, byte[] another)
        {
            return bytes.CompareTo(another) == 0;
        }

        /// <summary>
        /// Compares the number from bytes to another number.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <param name="bigEndian">True to use big endian, false to use little endian, null to follow system setting.</param>
        /// <returns>A positive integer if it's greater; Zero if they are equal and a negative integer if it's less than.</returns>
        public static int CompareTo(this byte[] bytes, byte[] another, bool? bigEndian = null)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            if (another == null)
            {
                throw new ArgumentNullException(nameof(another));
            }

            var length = bytes.Length >= another.Length ? bytes.Length : another.Length;

            if (!bigEndian.HasValue)
            {
                bigEndian = !BitConverter.IsLittleEndian;
            }

            if (bigEndian.Value)
            {
                var aLengthDiff = length - bytes.Length;
                var bLengthDiff = length - another.Length;

                for (var i = 0; i < length; i++)
                {
                    var a = i < aLengthDiff ? (byte)0 : bytes[i - aLengthDiff];
                    var b = i < bLengthDiff ? (byte)0 : another[i - bLengthDiff];

                    if (a == b)
                    {
                        continue;
                    }

                    return a > b ? 1 : -1;
                }
            }
            else
            {
                for (var i = length - 1; i >= 0; i--)
                {
                    var a = i >= bytes.Length ? (byte)0 : bytes[i];
                    var b = i >= another.Length ? (byte)0 : another[i];

                    if (a == b)
                    {
                        continue;
                    }

                    return a > b ? 1 : -1;
                }
            }

            return 0;
        }
    }
}
