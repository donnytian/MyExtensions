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
            if (bytes == null || bytes.Length == 0)
            {
                return new byte[0];
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
            if (bytes == null || bytes.Length == 0)
            {
                return new byte[0];
            }

            if (another == null || another.Length == 0)
            {
                return bytes;
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
            if (bytes == null || bytes.Length == 0)
            {
                return new byte[0];
            }

            if (another == null || another.Length == 0)
            {
                return bytes;
            }

            return bytes.Zip(another, (a, b) => (byte)(a | b)).ToArray();
        }

        /// <summary>
        /// Gets the bitwise OR result.
        /// </summary>
        /// <param name="bytes">The bytes to be calculated.</param>
        /// <param name="another">Another operant to be calculated.</param>
        /// <returns>The bitwise OR result bytes.</returns>
        public static byte[] GreaterOrEqual(this byte[] bytes, byte[] another)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return new byte[0];
            }

            if (another == null || another.Length == 0)
            {
                return bytes;
            }

            return bytes.Zip(another, (a, b) => (byte)(a | b)).ToArray();
        }
    }
}
