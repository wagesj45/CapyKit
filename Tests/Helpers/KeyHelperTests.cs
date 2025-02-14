using System;
using System.Text;
using NUnit.Framework;
using CapyKit.Helpers;

namespace Tests.Helpers
{
    [TestFixture]
    internal class KeyHelperTests
    {
        private KeyHelper _keyHelper;

        [SetUp]
        public void Setup()
        {
            _keyHelper = new KeyHelper();
            // Set up default accessors.
            _keyHelper.SetMasterKeyAccessor(() => Encoding.UTF8.GetBytes("TestMasterKey"));
            _keyHelper.SetSaltSizeAccessor(() => 4);
            _keyHelper.SetNumPartsAccessor(() => 4);
        }

        [Test]
        public void GenerateKey_ReturnsNonEmptyString()
        {
            string key = _keyHelper.GenerateKey();
            Assert.IsFalse(string.IsNullOrWhiteSpace(key), "Generated key should not be null or empty.");
        }

        [Test]
        public void ValidateKey_ReturnsTrueForValidKey()
        {
            string key = _keyHelper.GenerateKey();
            Assert.IsTrue(_keyHelper.ValidateKey(key), "Valid key should pass validation.");
        }

        [Test]
        public void ValidateKey_ReturnsFalseForAlteredKey()
        {
            string key = _keyHelper.GenerateKey();
            // Alter the key by changing one character.
            char firstChar = key[0];
            char alteredChar = firstChar == 'A' ? 'B' : 'A';
            string alteredKey = alteredChar + key.Substring(1);
            Assert.IsFalse(_keyHelper.ValidateKey(alteredKey), "Altered key should fail validation.");
        }

        [Test]
        public void ValidateKey_ReturnsFalseForEmptyOrNullKey()
        {
            Assert.IsFalse(_keyHelper.ValidateKey(null), "Null key should fail validation.");
            Assert.IsFalse(_keyHelper.ValidateKey(string.Empty), "Empty key should fail validation.");
            Assert.IsFalse(_keyHelper.ValidateKey("   "), "Whitespace key should fail validation.");
        }

        [Test]
        public void GenerateKey_WithCustomSaltSizeAndParts_FormatsCorrectly()
        {
            // Change to salt size of 8 bytes and 3 parts.
            _keyHelper.SetSaltSizeAccessor(() => 8);
            _keyHelper.SetNumPartsAccessor(() => 3);

            string key = _keyHelper.GenerateKey();
            string[] parts = key.Split('-');
            Assert.AreEqual(3, parts.Length, "Key should be split into 3 parts.");

            // Total hex length: salt (2 * saltSize) + signature (2 * saltSize) = 2*8 + 2*8 = 32.
            string concatenated = string.Concat(parts);
            Assert.AreEqual(32, concatenated.Length, "Combined hex length should be 32 characters.");
        }

        [Test]
        public void GetMasterKey_ThrowsException_WhenAccessorNotSet()
        {
            // Create a new helper without setting the master key accessor.
            KeyHelper helper = new KeyHelper();
            Assert.Throws<InvalidOperationException>(() => helper.GetMasterKey(), "Missing master key accessor should throw an exception.");
        }

        [Test]
        public void GetNumParts_ThrowsException_WhenLessThanTwo()
        {
            _keyHelper.SetNumPartsAccessor(() => 1);
            Assert.Throws<ArgumentException>(() => _keyHelper.GetNumParts(), "Setting less than two parts should throw an exception.");
        }
    }
}
