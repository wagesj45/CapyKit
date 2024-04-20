using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    /// <summary> A class that contains methods for managing secure data processing and cryptography. </summary>
    public class SecurityHelper
    {
        #region Members

        private int keySize = 32;
        private int saltSize = 32;

        /// <summary> The salt used when creating a hash using the <a href="https://en.wikipedia.org/wiki/SHA-2">SHA256</a> algorithm. </summary>
        private const string SALT = "D4260471-5DBA-4732-B960-6E2E438F8872";

        /// <summary> A string of all the lower case characters. </summary>
        private const string LOWER_CASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";

        /// <summary> A string of all the upper case characters. </summary>
        private const string UPPER_CASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary> A string of all the numeric characters. </summary>
        private const string NUMBER_CHARACTERS = "0123456789";

        /// <summary> A string of the most common non-alphanumeric characters. </summary>
        private const string SPECIAL_CHARACTERS = "!@#$%&?+-_";

        #endregion Members

        #region Methods

        /// <summary>
        /// Compares an unencrypted <paramref name="providedPassword"/> with a stored, encrypted
        /// <paramref name="existingPassword"/>.
        /// </summary>
        /// <param name="providedPassword"> The provided password, unencrypted. </param>
        /// <param name="existingPassword"> The existing, encrypted password. </param>
        /// <returns>
        /// <see langword="true"/> if hash comparison succeeds, <see langword="false"/> if it fails.
        /// </returns>
        public static bool CompareHashedPassword(string providedPassword, string existingPassword)
        {
            throw new NotImplementedException();
        }

        /// <summary> Hashes an unencrypted password. </summary>
        /// <param name="password"> The password. </param>
        /// <returns> The hashed password. </returns>
        public static string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces a <a href="https://en.wikipedia.org/wiki/SHA-2">SHA256</a> hash from a given
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value"> The value. </param>
        /// <returns>
        /// A byte array equal to the SHA256 hash of <paramref name="value"/> or an empty array if it
        /// fails.
        /// </returns>
        public static byte[] SHA256Hash(string value)
        {
            try
            {
                using (var hash = new SHA256Managed())
                {
                    var bytes = Encoding.Unicode.GetBytes(value + SALT);
                    var encrypted = hash.ComputeHash(bytes);
                    return encrypted;
                }
            }
            catch (Exception ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not hash the given value {0}.", args: new[] { value });
            }

            return new byte[0];
        }

        public static string Pbkdf2(string password, out byte[] salt)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets a cryptographically strong random password. </summary>
        /// <param name="length"> The length of the password to generate. </param>
        /// <returns> The password. </returns>
        public static string GetRandomPassword(int length)
        {
            return GetRandomString(length);
        }

        /// <summary> Gets a calendar key that is <c>32</c> characters long. </summary>
        /// <returns> The calendar key. </returns>
        public static string GetCalendarKey()
        {
            return GetRandomString(32);
        }

        /// <summary> Compares two session identifiers. </summary>
        /// <param name="first">  The first session identifier. </param>
        /// <param name="second"> The second session identifier. </param>
        /// <returns>
        /// <see langword="true"/> if comparison succeeds, <see langword="false"/> if not.
        /// </returns>
        public static bool CompareSessionID(string first, string second)
        {
            if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
            {
                return CompareStrings(first, second);
            }
            return CompareStrings(first.Trim(), second.Trim());
        }

        /// <summary> Gets a cryptographically strong random string using the character values found in <see cref="VALID_CHARACTERS"/>. </summary>
        /// <param name="length"> The length of the string to create. </param>
        /// <returns> The random string. </returns>
        private static string GetRandomString(int length)
        {
            throw new NotImplementedException();
            //var buffer = new StringBuilder();
            //while (buffer.Length < length)
            //{
            //    var oneByte = new byte[1];
            //    RandomNumberGenerator.GetBytes(oneByte);
            //    var character = (char)oneByte[0];
            //    if (VALID_CHARACTERS.Contains(character))
            //    {
            //        buffer.Append(character);
            //    }
            //}

            //return buffer.ToString();
        }

        /// <summary> Compare two strings as case sensative. </summary>
        /// <param name="first">  The first string. </param>
        /// <param name="second"> The second string. </param>
        /// <returns>
        /// <see langword="true"/> if the comparison succeeds, <see langword="false"/> if not.
        /// </returns>
        /// <remarks>
        /// This method is a proxy for using
        /// <see cref="string.Compare(string, int, string, int, int, StringComparison)"/> with the
        /// <c>StringComparison</c> set to <see cref="StringComparison.Ordinal"/>.
        /// </remarks>
        private static bool CompareStrings(string first, string second)
        {
            return string.Compare(first, second, StringComparison.Ordinal) == 0;
        }

        #endregion Methods
    }
}
