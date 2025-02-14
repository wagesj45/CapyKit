using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Net;

namespace CapyKit.Helpers
{
    /// <summary> A class that contains methods for managing key creation and validation against a master key. </summary>
    public class KeyHelper
    {
        /// <summary> The master key accessor function. </summary>
        private Func<byte[]> masterKeyAccessor;
        /// <summary> The salt size accessor function. </summary>
        private Func<int> saltSizeAccessor;
        /// <summary> Number of parts accessor function. </summary>
        private Func<int> numPartsAccessor;

        /// <summary> Sets the master key. </summary>
        /// <param name="accessor"> The accessor function. </param>
        public void SetMasterKeyAccessor(Func<byte[]> accessor)
        {
            this.masterKeyAccessor = accessor;
        }

        /// <summary> Gets the master key. </summary>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when the requested operation is invalid.
        /// </exception>
        /// <returns> An array of byte. </returns>
        public byte[] GetMasterKey()
        {
            if (this.masterKeyAccessor == null)
            {
                var errorMessage = "Master key accessor not set.";
                CapyEventReporter.EmitEvent(EventLevel.Error, errorMessage);
                throw new InvalidOperationException(errorMessage);
            }
            return this.masterKeyAccessor();
        }

        /// <summary> Sets the salt size (in bytes). Default is 4. </summary>
        /// <param name="accessor"> The accessor function. </param>
        public void SetSaltSizeAccessor(Func<int> accessor)
        {
            this.saltSizeAccessor = accessor;
        }

        /// <summary> Gets the salt size. </summary>
        /// <returns> The salt size. </returns>
        public int GetSaltSize()
        {
            return this.saltSizeAccessor != null ? this.saltSizeAccessor() : 4;
        }

        /// <summary> Set and get the number of parts for the formatted key. Default is 2. </summary>
        /// <param name="accessor"> The accessor function. </param>
        public void SetNumPartsAccessor(Func<int> accessor)
        {
            this.numPartsAccessor = accessor;
        }

        /// <summary> Gets the number parts. </summary>
        /// <exception cref="ArgumentException">
        ///     Thrown when one or more arguments have unsupported or illegal values.
        /// </exception>
        /// <returns> The number parts. </returns>
        public int GetNumParts()
        {
            int parts = this.numPartsAccessor != null ? this.numPartsAccessor() : 2;
            if (parts < 2)
            {
                var errorMessage = "Number of parts must be 2 or more.";
                CapyEventReporter.EmitEvent(EventLevel.Error, errorMessage);
                throw new ArgumentException(errorMessage);
            }
            return parts;
        }

        /// <summary>
        /// Computes an HMAC-SHA256 over the salt using the master key and truncates it to the same
        /// number of bytes as the salt.
        /// </summary>
        /// <param name="salt"> The salt. </param>
        /// <returns> The calculated signature. </returns>
        private byte[] ComputeSignature(byte[] salt)
        {
            byte[] masterKey = GetMasterKey();
            using (var hmac = new HMACSHA256(masterKey))
            {
                byte[] hash = hmac.ComputeHash(salt);
                int sigLength = salt.Length;
                byte[] signature = new byte[sigLength];
                Array.Copy(hash, signature, sigLength);
                return signature;
            }
        }

        /// <summary> Converts a byte array to a hex string. </summary>
        /// <param name="bytes"> The bytes. </param>
        /// <returns> A string. </returns>
        private string BytesToHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary> Converts a hex string back to a byte array. </summary>
        /// <exception cref="ArgumentException">
        ///     Thrown when one or more arguments have unsupported or illegal values.
        /// </exception>
        /// <param name="hex"> The hexadecimal. </param>
        /// <returns> A byte[]. </returns>
        private byte[] HexToBytes(string hex)
        {
            if (hex.Length % 2 != 0)
            {
                var errorMessage = "Invalid hex string.";
                CapyEventReporter.EmitEvent(EventLevel.Error, errorMessage);
                throw new ArgumentException(errorMessage);
            }
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// Formats the given hex string into the desired number of parts (separated by dashes).
        /// </summary>
        /// <param name="hex"> The hexadecimal. </param>
        /// <returns> The formatted key. </returns>
        private string FormatKey(string hex)
        {
            int parts = GetNumParts();
            int totalLength = hex.Length;
            int baseLength = totalLength / parts;
            int remainder = totalLength % parts;

            StringBuilder formatted = new StringBuilder();
            int currentIndex = 0;
            for (int i = 0; i < parts; i++)
            {
                // Distribute any extra characters across the first few groups.
                int groupLength = baseLength + (i < remainder ? 1 : 0);
                formatted.Append(hex.Substring(currentIndex, groupLength));
                currentIndex += groupLength;
                if (i < parts - 1)
                    formatted.Append("-");
            }
            return formatted.ToString();
        }

        /// <summary> Generates a random key. </summary>
        /// <returns> The key. </returns>
        public string GenerateKey()
        {
            int saltSize = GetSaltSize();
            byte[] salt = new byte[saltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] signature = ComputeSignature(salt);
            string saltHex = BytesToHex(salt);
            string signatureHex = BytesToHex(signature);
            string combinedHex = saltHex + signatureHex;
            return FormatKey(combinedHex);
        }

        /// <summary> Validates the provided key. </summary>
        /// <param name="providedKey"> The provided key. </param>
        /// <returns> True if it succeeds, false if it fails. </returns>
        /// <seealso cref="GetMasterKey"/>
        /// <seealso cref="SetMasterKeyAccessor(Func{byte[]})"/>
        /// <seealso cref="masterKeyAccessor"/>
        public bool ValidateKey(string providedKey)
        {
            if (string.IsNullOrWhiteSpace(providedKey))
                return false;

            // Remove dashes.
            string cleanedKey = providedKey.Replace("-", "");
            int saltSize = GetSaltSize();
            int expectedTotalHexLength = 4 * saltSize; // salt (2*saltSize) + signature (2*saltSize)
            if (cleanedKey.Length != expectedTotalHexLength)
                return false;

            string saltHex = cleanedKey.Substring(0, 2 * saltSize);
            string signatureHex = cleanedKey.Substring(2 * saltSize);

            byte[] salt;
            byte[] providedSignature;
            try
            {
                salt = HexToBytes(saltHex);
                providedSignature = HexToBytes(signatureHex);
            }
            catch
            {
                return false;
            }

            byte[] expectedSignature = ComputeSignature(salt);
            if (expectedSignature.Length != providedSignature.Length)
                return false;

            for (int i = 0; i < expectedSignature.Length; i++)
            {
                if (expectedSignature[i] != providedSignature[i])
                    return false;
            }
            return true;
        }
    }
}
