using CapyKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    internal class PasswordTests
    {
        private static byte[] GenerateSalt(int size = 16)
        {
            var salt = new byte[size];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        [Test]
        public void PasswordCreation_WithPbkdf2Algorithm_CreatesValidHash()
        {
            // Arrange
            var passwordText = "mySecurePassword";
            var salt = GenerateSalt();
            var algorithm = Password.Pbkdf2Algorithm;

            // Act
            var password = new Password(passwordText, salt, algorithm);

            // Assert
            Assert.IsNotNull(password.Hash);
            Assert.IsNotEmpty(password.Hash);
            Assert.AreEqual(salt, password.Salt);
            Assert.AreEqual(algorithm, password.Algorithm);
        }

        [Test]
        public void PasswordEquality_SamePasswordAndSalt_AreEqual()
        {
            // Arrange
            var passwordText = "mySecurePassword";
            var salt = GenerateSalt();
            var algorithm = Password.Pbkdf2Algorithm;

            var password1 = new Password(passwordText, salt, algorithm);
            var password2 = new Password(passwordText, salt, algorithm);

            // Act & Assert
            Assert.AreEqual(password1, password2);
            Assert.IsTrue(password1 == password2);
        }

        [Test]
        public void PasswordEquality_DifferentPasswords_AreNotEqual()
        {
            // Arrange
            var salt = GenerateSalt();
            var algorithm = new Pbkdf2Algorithm();

            var password1 = new Password("passwordOne", salt, algorithm);
            var password2 = new Password("passwordTwo", salt, algorithm);

            // Act & Assert
            Assert.AreNotEqual(password1, password2);
            Assert.IsTrue(password1 != password2);
        }

        [Test]
        public void PasswordEquality_DifferentSalts_AreNotEqual()
        {
            // Arrange
            var passwordText = "mySecurePassword";
            var salt1 = GenerateSalt();
            var salt2 = GenerateSalt();
            var algorithm = Password.Pbkdf2Algorithm;

            var password1 = new Password(passwordText, salt1, algorithm);
            var password2 = new Password(passwordText, salt2, algorithm);

            // Act & Assert
            Assert.AreNotEqual(password1, password2);
            Assert.IsTrue(password1 != password2);
        }

        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            // Arrange
            var passwordText = "mySecurePassword";
            var salt = GenerateSalt();
            var algorithm = Password.Pbkdf2Algorithm;

            var password = new Password(passwordText, salt, algorithm);

            // Act
            var result = password.ToString();

            // Assert
            Assert.IsTrue(result.Contains("Hash:"));
            Assert.IsTrue(result.Contains("Salt:"));
            Assert.IsTrue(result.Contains("Algorithm: Pbkdf2"));
        }

        [Test]
        public void PasswordCreation_WithInvalidSalt_ReturnsEmptyHash()
        {
            // Arrange
            var passwordText = "mySecurePassword";
            byte[] invalidSalt = null; // Invalid salt
            var algorithm = new Pbkdf2Algorithm();

            // Act
            var password = new Password(passwordText, invalidSalt, algorithm);

            // Assert
            Assert.IsNotNull(password.Hash);
            Assert.IsEmpty(password.Hash);
        }
    }
}
