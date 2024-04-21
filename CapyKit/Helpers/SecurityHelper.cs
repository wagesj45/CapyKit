using CapyKit.Attributes;
using CapyKit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    /// <summary> A class that contains methods for managing secure data processing and cryptography. </summary>
    public class SecurityHelper
    {
        #region Members

        /// <summary> Default size of the generated salt. </summary>
        private const int saltSize = 32;

        /// <summary> A string of all the lower case characters. </summary>
        internal const string LOWER_CASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";

        /// <summary> A string of all the upper case characters. </summary>
        internal const string UPPER_CASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary> A string of all the numeric characters. </summary>
        internal const string NUMBER_CHARACTERS = "0123456789";

        /// <summary> A string of the most common non-alphanumeric characters. </summary>
        internal const string SPECIAL_CHARACTERS = "!@#$%&?+-_";

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
        /// Generates a new <see cref="Password"/> object using the PBKDF2 algorithm with the provided <paramref name="password"/>
        /// and <paramref name="salt"/>.
        /// </summary>
        /// <remarks>
        /// This method uses the PBKDF2 (Password-Based Key Derivation Function 2) algorithm to generate
        /// a new password hash. The algorithm iteratively applies a pseudorandom function to the
        /// password and salt, which increases the security of the resulting hash.
        /// </remarks>
        /// <param name="password"> The clear text password to be hashed. </param>
        /// <param name="salt">
        ///     A random value used to add an additional layer of security to the generated hash.
        /// </param>
        /// <returns>
        /// A new <see cref="Password"/> object containing the hashed password and salt.
        /// </returns>
        public static Password Pbkdf2(string password, byte[] salt)
        {
            var pwd = new Password(password, salt, Password.Pbkdf2Algorithm);

            return pwd;
        }

        /// <summary>
        /// Generates a new <see cref="Password"/> object using the PBKDF2 algorithm with the provided <paramref name="password"/>.
        /// This overload of the method generates a random salt value for added security.
        /// </summary>
        /// <remarks>
        /// This method uses the PBKDF2 (Password-Based Key Derivation Function 2) algorithm to generate
        /// a new password hash. The algorithm iteratively applies a pseudorandom function to the
        /// password and salt, which increases the security of the resulting hash. In this overload,
        /// a random salt value is generated using <see cref="SecurityHelper.GetRandomBytes(int)"/> method.
        /// </remarks>
        /// <param name="password"> The clear text password to be hashed. </param>
        /// <returns>
        /// A new <see cref="Password"/> object containing the hashed password and a randomly generated salt.
        /// </returns>
        public static Password Pbkdf2(string password)
        {
            var salt = SecurityHelper.GetRandomBytes(saltSize);
            var pwd = new Password(password, salt, Password.Pbkdf2Algorithm);

            return pwd;
        }

        /// <summary> Gets a cryptographically strong random password. </summary>
        /// <param name="length"> The length of the password to generate. </param>
        /// <returns> The password. </returns>
        public static string GetRandomPassword(int length, params ValidCharacterCollection[] validCharacters)
        {
            return GetRandomString(length, validCharacters);
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

        /// <summary>
        /// A convenience method to generate a random string of the specified length using all character sets.
        /// </summary>
        /// <param name="length"> The desired length of the generated random string.</param>
        /// <seealso cref="ValidCharacterCollection"/>
        /// <seealso cref="GetRandomString(int, ValidCharacterCollection[])"/>
        public static string GetRandomString(int length)
        {
            return GetRandomString(length,
                ValidCharacterCollection.Lowercase,
                ValidCharacterCollection.Uppercase,
                ValidCharacterCollection.Numbers,
                ValidCharacterCollection.Special);
        }

        /// <summary> Gets a cryptographically strong random string using the character values found in <see cref="VALID_CHARACTERS"/>. </summary>
        /// <param name="length"> The length of the string to create. </param>
        /// <returns> The random string. </returns>
        public static string GetRandomString(int length, params ValidCharacterCollection[] validChars)
        {
            var buffer = new StringBuilder(length);
            var randomNumberBuffer = new byte[length * 3]; // Overprovision the buffer so we can discard a small percentage.
            var validCharacters = GetValidCharacterComposition(validChars);
            var validByteUpperLimit = (256 / validCharacters.Length) * validCharacters.Length - 1; // Maintains equal distribution of valid characters.

            using (var rng = RandomNumberGenerator.Create())
            {
                while (buffer.Length < length)
                {
                    rng.GetBytes(randomNumberBuffer);
                    foreach (byte b in randomNumberBuffer)
                    {
                        if (b <= validByteUpperLimit)
                        {
                            int index = b % validCharacters.Length;
                            buffer.Append(validCharacters[index]);
                            if (buffer.Length == length)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return buffer.ToString();
        }

        /// <summary> Generates a new byte array of the specified length with random values. </summary>
        /// <param name="length"> The desired length of the generated byte array. </param>
        /// <returns> A new byte array of the specified length filled with random values. </returns>
        private static byte[] GetRandomBytes(int length)
        {
            var buffer = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(buffer);
            }

            return buffer;
        }

        private static string GetValidCharacterComposition(params ValidCharacterCollection[] validCharacters)
        {
            var composition = new StringBuilder();
            foreach (var c in validCharacters)
            {
                switch (c)
                {
                    case ValidCharacterCollection.Lowercase:
                        composition.Append(LOWER_CASE_CHARACTERS);
                        break;
                    case ValidCharacterCollection.Uppercase:
                        composition.Append(LOWER_CASE_CHARACTERS);
                        break;
                    case ValidCharacterCollection.Numbers:
                        composition.Append(LOWER_CASE_CHARACTERS);
                        break;
                    case ValidCharacterCollection.Special:
                        composition.Append(LOWER_CASE_CHARACTERS);
                        break;
                    default:
                        break;
                }
            }

            return composition.ToString();
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

    /// <summary>
    /// An enumeration that defines the types of characters that can be included in a random string.
    /// </summary>
    public enum ValidCharacterCollection
    {
        /// <summary>
        /// Indicates that lower case characters should be included in the random string.
        /// </summary>
        [EnumerationDescriptionAttribute(SecurityHelper.LOWER_CASE_CHARACTERS)]
        Lowercase,
        /// <summary>
        /// Indicates that upper case characters should be included in the random string.
        /// </summary>
        [EnumerationDescriptionAttribute(SecurityHelper.UPPER_CASE_CHARACTERS)]
        Uppercase,
        /// <summary>
        /// Indicates that numeric characters should be included in the random string.
        /// </summary>
        [EnumerationDescriptionAttribute(SecurityHelper.NUMBER_CHARACTERS)]
        Numbers,
        /// <summary>
        /// Indicates that special characters should be included in the random string.
        /// </summary>
        [EnumerationDescriptionAttribute(SecurityHelper.SPECIAL_CHARACTERS)]
        Special,
    }
}
