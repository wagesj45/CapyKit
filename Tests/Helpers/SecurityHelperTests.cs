using CapyKit;
using CapyKit.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Tests.Helpers
{
    [TestFixture]
    internal class SecurityHelperTests
    {
        private const string Password = "TestPassword";
        private static readonly byte[] Salt = SecurityHelper.GetSalt();

        [Test]
        public void CompareHashedPassword_WithSamePassword_ShouldReturnTrue()
        {
            var existingPassword = SecurityHelper.Pbkdf2(Password, Salt);
            var result = SecurityHelper.CompareHashedPassword<Pbkdf2Algorithm>(existingPassword, Password, Salt);

            Assert.IsTrue(result);
        }

        [Test]
        public void CompareHashedPassword_WithDifferentPassword_ShouldReturnFalse()
        {
            var existingPassword = SecurityHelper.Pbkdf2(Password, Salt);
            var result = SecurityHelper.CompareHashedPassword<Pbkdf2Algorithm>(existingPassword, "WrongPassword", Salt);

            Assert.IsFalse(result);
        }

        [Test]
        public void CompareSessionID_WithSameSessionIDs_ShouldReturnTrue()
        {
            var sessionID1 = "SessionID";
            var sessionID2 = "SessionID";

            var result = SecurityHelper.CompareSessionID(sessionID1, sessionID2);

            Assert.IsTrue(result);
        }

        [Test]
        public void CompareSessionID_WithDifferentSessionIDs_ShouldReturnFalse()
        {
            var sessionID1 = "SessionID1";
            var sessionID2 = "SessionID2";

            var result = SecurityHelper.CompareSessionID(sessionID1, sessionID2);

            Assert.IsFalse(result);
        }

        [Test]
        public void GetRandomString_ShouldReturnStringOfGivenLength()
        {
            int length = 10;
            var randomString = SecurityHelper.GetRandomString(length);

            Assert.AreEqual(length, randomString.Length);
        }

        [Test]
        public void GetRandomPassword_ShouldReturnStringOfGivenLength()
        {
            int length = 12;
            var randomPassword = SecurityHelper.GetRandomPassword(length);

            Assert.AreEqual(length, randomPassword.Length);
        }

        [Test]
        public void Pbkdf2_WithSamePasswordAndSalt_ShouldReturnSameHash()
        {
            var password1 = SecurityHelper.Pbkdf2(Password, Salt);
            var password2 = SecurityHelper.Pbkdf2(Password, Salt);

            Assert.AreEqual(password1.Hash, password2.Hash);
        }

        //[Test]
        //public void GetPassword_WithPBKDF2Algorithm_ShouldReturnValidPasswordObject()
        //{
        //    var password = SecurityHelper.GetPassword<Pbkdf2Algorithm>(Password, Salt);

        //    Assert.IsNotNull(password);
        //    Assert.AreEqual(Password, password);
        //}

        //[Test]
        //public void GetPassword_WithDifferentAlgorithm_ShouldReturnDifferentHashes()
        //{
        //    var password1 = SecurityHelper.GetPassword<Pbkdf2Algorithm>(Password, Salt);
        //    var password2 = SecurityHelper.GetPassword<SomeOtherAlgorithm>(Password, Salt); // Replace with another algorithm implementation

        //    Assert.AreNotEqual(password1.Hash, password2.Hash);
        //}

        //[Test]
        //public void GetRandomBytes_ShouldReturnArrayOfGivenLength()
        //{
        //    int length = 16;
        //    var bytes = SecurityHelper.GetRandomBytes(length);

        //    Assert.AreEqual(length, bytes.Length);
        //}
    }
}
