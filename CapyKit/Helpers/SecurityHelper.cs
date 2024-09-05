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

        /// <summary> Default size to use when generating a new salt. </summary>
        private const int SALT_SIZE = 32;

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
        /// Compares an unencrypted <paramref name="password"/> with a stored, encrypted <paramref name="existingPassword"/>.
        /// This method uses the specified password algorithm type <typeparamref name="T"/> to retrieve the hashed version
        /// of the <paramref name="password"/> and then compares it with the <paramref name="existingPassword"/>.
        /// </summary>
        /// <typeparam name="T">The type of the password hashing algorithm.</typeparam>
        /// <param name="existingPassword">The existing, encrypted password.</param>
        /// <param name="password">The unencrypted password to be compared.</param>
        /// <param name="salt">The salt value used in password hashing.</param>
        /// <param name="args">Additional arguments required for constructing the password algorithm instance.</param>
        /// <returns>
        /// <see langword="true"/> if hash comparison succeeds, <see langword="false"/> if it fails.
        /// </returns>
        public static bool CompareHashedPassword<T>(Password existingPassword, string password, byte[] salt, params object[] args)
        {
            var providedPassword = typeof(SecurityHelper)
                .GetMethod("GetPassword")
                ?.MakeGenericMethod(typeof(T))
                ?.Invoke(null, new object[] { password, salt, args });

            return existingPassword.Equals(providedPassword);
        }

        /// <summary>
        /// Compares an unencrypted <paramref name="password"/> with a stored, encrypted <paramref name="existingPassword"/>.
        /// This method uses the specified <paramref name="algorithm"/> to retrieve the hashed version
        /// of the <paramref name="password"/> and then compares it with the <paramref name="existingPassword"/>.
        /// </summary>
        /// <param name="existingPassword">The existing, encrypted password.</param>
        /// <param name="password">The unencrypted password to be compared.</param>
        /// <param name="salt">The salt value used in password hashing.</param>
        /// <param name="algorithm">The password hashing algorithm.</param>
        /// <param name="args">Additional arguments required for constructing the password algorithm instance.</param>
        /// <returns>
        /// <see langword="true"/> if hash comparison succeeds, <see langword="false"/> if it fails.
        /// </returns>
        public static bool CompareHashedPassword(Password existingPassword, string password, byte[] salt, IPasswordAlgorithm algorithm, params object[] args)
        {
            var algorithmType = algorithm.GetType();

            var providedPassword = typeof(SecurityHelper)
                .GetMethod("GetPassword")
                ?.MakeGenericMethod(algorithmType)
                ?.Invoke(null, new object[] { password, salt, args });

            return existingPassword.Equals(providedPassword);
        }

        /// <summary>
        /// Retrieves a <see cref="Password"/> object using the specified password and generates a random salt value.
        /// Then it uses that salt to call the overloaded <see cref="GetPassword{T}(string, byte[], object[])"/> method with the given password and
        /// the generated salt as arguments.
        /// </summary>
        /// <typeparam name="T"> The type of <see cref="IPasswordAlgorithm"/> implementation to use. </typeparam>
        /// <param name="password"> The plaintext password to be hashed. </param>
        /// <param name="args">
        ///     Optional constructor arguments for the <see cref="IPasswordAlgorithm"/> implementation
        ///     instance.
        /// </param>
        /// <returns>
        /// A new <see cref="Password"/> object with the given password and a randomly generated salt, as well as an
        /// instance of <typeparamref name="T"/> created using any optional constructor arguments provided.
        /// </returns>
        /// <seealso cref="SecurityHelper.SALT_SIZE"/>
        public static Password GetPassword<T>(string password, params object[] args)
        {
            var salt = SecurityHelper.GetSalt;
            return GetPassword<T>(password, salt, args);
        }

        /// <summary>
        /// Retrieves a <see cref="Password"/> object using the specified password, salt, and optional
        /// constructor arguments.
        /// </summary>
        /// <remarks>
        /// This method uses reflection to find a constructor for the specified password algorithm type (<typeparamref name="T"/>).
        /// It emits an error event if a suitable constructor is not found or if there is an error invoking the constructor.
        /// </remarks>
        /// <typeparam name="T">
        ///     The type of <see cref="IPasswordAlgorithm"/> implementation to use.
        /// </typeparam>
        /// <param name="password"> The plaintext password to be hashed. </param>
        /// <param name="salt">
        ///     A random value used as an additional input to the one-way function that hashes data, a
        ///     password or passphrase. This is used to make each output different for the same input
        ///     thus adding security.
        /// </param>
        /// <param name="args">
        ///     Optional constructor arguments for the <see cref="IPasswordAlgorithm"/> implementation
        ///     instance.
        /// </param>
        /// <returns>
        /// A new <see cref="Password"/> object with the given password and salt, as well as an instance
        /// of <typeparamref name="T"/> created using the provided constructor arguments.
        /// </returns>
        public static Password GetPassword<T>(string password, byte[] salt, params object[] args) where T : IPasswordAlgorithm
        {
            var allArgs = args.Prepend(salt).Prepend(password).ToArray(); // Prepend in reverse order so that password precedes salt.
            var argTypes = allArgs.Select(arg => arg.GetType()).ToArray();
            var algorithmConstructor = typeof(T).GetConstructor(argTypes);

            if (algorithmConstructor == null)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Cannot find a constructor for {0} that matches the given arguments: {1}",
                    args: new[]
                    {
                        typeof(T).Name,
                        string.Join(",", argTypes.Select(arg => arg.Name))
                    });
                return default(Password);
            }

            var passwordInstance = (T)algorithmConstructor.Invoke(allArgs);

            if (passwordInstance == null)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "There was an error invoking the constructor for {0} with the given arguments: {1}",
                    args: new[]
                    {
                        typeof(T).Name,
                        string.Join(",", allArgs)
                    });
                return default(Password);
            }

            return new Password(password, salt, passwordInstance, args);
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
            var salt = SecurityHelper.GetRandomBytes(SALT_SIZE);
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

        /// <summary> Generates a random byte array that can act as a salt. </summary>
        /// <remarks>
        /// A default length of <see cref="SALT_SIZE"/> is provided as a sane default. Larger values can be used for increased
        /// entropy.
        /// </remarks>
        /// <param name="length"> (Optional) The desired length of the generated byte array. </param>
        /// <returns> An array of byte. </returns>
        public static byte[] GetSalt(int length = SALT_SIZE)
        {
            return GetRandomBytes(length);
        }

        /// <summary> Generates a new byte array of the specified length with random values. </summary>
        /// <param name="length"> The desired length of the generated byte array. </param>
        /// <returns> A new byte array of the specified length filled with random values. </returns>
        private static byte[] GetRandomBytes(int length)
        {
            if(length <= 0)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Length must be greater than 0.");
                return GetRandomBytes(16);
            }

            var buffer = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(buffer);
            }

            return buffer;
        }

        /// <summary>
        /// Static method that returns a valid character composition based on the given ValidCharacterCollection parameters.
        /// </summary>
        /// <param name="validCharacters">An array of ValidCharacterCollection enumeration values representing the desired character sets.</param>
        /// <returns>A string containing all the characters from the specified character sets.</returns>
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
