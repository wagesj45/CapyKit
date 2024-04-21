using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit
{
    /// <summary>
    /// Represents a password with its hash, salt and algorithm used for encryption.
    /// </summary>
    public class Password
    {
        #region Members

        private static Lazy<Pbkdf2Algorithm> algorithm = new Lazy<Pbkdf2Algorithm>(() => new Pbkdf2Algorithm());

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the hash of the password.
        /// </summary>
        public byte[] Hash { get; private set; }

        /// <summary>
        /// Gets or sets the salt used for encryption.
        /// </summary>
        public byte[] Salt { get; private set; }

        /// <summary>
        /// Gets or sets the algorithm used for password encryption.
        /// </summary>
        public IPasswordAlgorithm Algorithm { get; private set; }

        public static Pbkdf2Algorithm Pbkdf2Algorithm
        {
            get
            {
                return algorithm.Value;
            }
        }

        #endregion

        /// <summary> Constructor. </summary>
        /// <param name="password">  The password to be hashed. </param>
        /// <param name="salt">      The salt used for encryption. </param>
        /// <param name="algorithm"> The algorithm used for password encryption. </param>
        /// <param name="args">      A variable-length parameters list containing arguments to include for the <paramref name="algorithm"/>. </param>
        internal Password(string password, byte[] salt, IPasswordAlgorithm algorithm, params object[] args) 
        {
            // We know there will always be a salt, so we can prepend it to h
            var augmented = args.Prepend(salt).ToArray();

            this.Hash = algorithm.Encrypt(password, augmented);
            this.Salt = salt;
            this.Algorithm = algorithm;
        }

        #region Methods

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("Hash: {0}, Salt: {1}, Algorithm: {2}", BitConverter.ToString(this.Hash), BitConverter.ToString(this.Salt), this.Algorithm?.AlgorithmName);
        }

        #endregion
    }

    /// <summary>
    /// Defines the contract for password encryption algorithms.
    /// </summary>
    public interface IPasswordAlgorithm
    {
        #region Properties

        /// <summary>
        /// Gets the name of the algorithm.
        /// </summary>
        string AlgorithmName { get; }

        #endregion

        #region Methods

        /// <summary> Encrypts the given password using a defined algorithm. </summary>
        /// <param name="password"> The plaintext password. </param>
        /// <param name="args">
        ///     Additional arguments for the encryption process, such as salt and length.
        /// </param>
        /// <returns> A byte array with the hashed <paramref name="password"/>. </returns>
        byte[] Encrypt(string password, params object[] args);

        /// <summary>
        /// Compares the given plaintext password with an encrypted value using PBKDF2 algorithm.
        /// </summary>
        /// <param name="password">       The plaintext password to compare. </param>
        /// <param name="encryptedValue"> The encrypted value to compare against. </param>
        /// <param name="args">
        ///     Additional arguments for the encryption process, such as salt and length.
        /// </param>
        /// <returns>
        /// True if the given <paramref name="password"/> matches the <paramref name="encryptedValue"/>,
        /// false if they are different.
        /// </returns>
        bool Compare(string password, byte[] encryptedValue, params object[] args)
        {
            var challengedPassword = Encrypt(password, args);

            return encryptedValue.SequenceEqual(challengedPassword);
        }

        #endregion
    }

    #region Implementations

    /// <summary>
    /// Implements the PBKDF2 algorithm for password encryption.
    /// </summary>
    public class Pbkdf2Algorithm : IPasswordAlgorithm
    {
        #region Members
        
        /// <summary> (Immutable) The default length. </summary>
        /// <remarks> This member is immutable. </remarks>
        public const int LENGTH = 32;

        /// <summary> The default number of iterations. </summary>
        /// <remarks> This member is immutable. </remarks>
        public const int ITERATIONS = 100000; 
        
        #endregion

        #region Properties

        /// <inheritdoc/>
        public string AlgorithmName
        {
            get
            {
                return "Pbkdf2";
            }
        }

        #endregion

        #region Methods

        /// <summary> Encrypts the given password using a PBKDF2 algorithm. </summary>
        /// <param name="password"> The plaintext password. </param>
        /// <param name="args">
        ///     Additional arguments for the encryption process, specifically
        ///     <list type="number">
        ///     <item><c>salt</c></item>
        ///     <item><c>length</c></item>
        ///     <item><c>iterations</c></item>
        ///     </list>
        /// </param>
        /// <returns> A byte array with the hashed <paramref name="password"/>. </returns>
        public byte[] Encrypt(string password, params object[] args)
        {
            if (args.Length == 0)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "No arguments passed.");
                return new byte[0];
            }

            var salt = args[0] as byte[];

            if (salt == null)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "The first parameters in the arguments wasn't a valid salt.");
                return new byte[0];
            }

            var length = 0;
            try
            {
                length = Convert.ToInt32(args[1]);
            }
            catch (Exception ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not convert the second parameter into an integer.");
                length = LENGTH;
            }

            var iterations = 0;
            try
            {
                iterations = Convert.ToInt32(args[2]);
            }
            catch (Exception ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not convert the second parameter into an integer.");
                iterations = ITERATIONS;
            }

            var hash = new byte[0];

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                hash = deriveBytes.GetBytes(length);
            }

            if (hash.Length == 0)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Hash could not be generated.");
                return new byte[0];
            }

            return hash;
        } 

        #endregion
    }

    #endregion
}
