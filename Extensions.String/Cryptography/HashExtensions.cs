using System;
using System.Security.Cryptography;
using System.Text;

namespace Extensions.String.Cryptography
{
    /// <summary>
    /// Provides hash extensions for <see cref="string"/> class.
    /// </summary>
    public static class HashExtensions
    {
        /// <summary>
        /// Computes MD5 hash value for the string.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The hash string.</returns>
        public static string Md5(this string s)
        {
            using (var algorithm = MD5.Create())
            {
                return ComputeHash(s, algorithm);
            }
        }

        /// <summary>
        /// Computes SHA1 hash value for the string.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The hash string.</returns>
        public static string Sha1(this string s)
        {
            using (var algorithm = SHA1.Create())
            {
                return ComputeHash(s, algorithm);
            }
        }

        /// <summary>
        /// Computes SHA256 hash value for the string.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The hash string.</returns>
        public static string Sha256(this string s)
        {
            using (var algorithm = SHA256.Create())
            {
                return ComputeHash(s, algorithm);
            }
        }

        /// <summary>
        /// Computes SHA384 hash value for the string.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The hash string.</returns>
        public static string Sha384(this string s)
        {
            using (var algorithm = SHA384.Create())
            {
                return ComputeHash(s, algorithm);
            }
        }

        /// <summary>
        /// Computes SHA512 hash value for the string.
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The hash string.</returns>
        public static string Sha512(this string s)
        {
            using (var algorithm = SHA512.Create())
            {
                return ComputeHash(s, algorithm);
            }
        }

        private static string ComputeHash(string s, HashAlgorithm algorithm)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            var hashBytes = algorithm.ComputeHash(bytes);

            return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
        }
    }
}
