using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using CapyKit.Extensions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class StringExtensions
    {
        private const string Replacement = "Replaced";

        [SetUp]
        public void Setup()
        {
            // No setup required for this test fixture.
        }

        #region IfNullOrEmpty

        [TestCase("")]
        public void IfNullOrEmpty_ShouldReturnReplacementWhenValueIsNullOrEmpty(string value)
        {
            var result = value.IfNullOrEmpty(Replacement);

            Assert.AreEqual(Replacement, result);
        }

        [TestCase("Not Empty")]
        [TestCase("   ")] // Whitespace is not considered empty
        public void IfNullOrEmpty_ShouldReturnOriginalStringWhenValueIsNotNullNorEmpty(string value)
        {
            var result = value.IfNullOrEmpty(Replacement);

            Assert.AreEqual(value, result);
        }

        #endregion

        #region IfNullOrWhiteSpace

        [TestCase("")]
        [TestCase("   ")] // Whitespace is considered empty
        public void IfNullOrWhiteSpace_ShouldReturnReplacementWhenValueIsNullOrWhitespace(string value)
        {
            var result = value.IfNullOrWhiteSpace(Replacement);

            Assert.AreEqual(Replacement, result);
        }

        [TestCase("Not Empty")]
        [TestCase("\tTab")] // Non-whitespace character is not considered empty
        public void IfNullOrWhiteSpace_ShouldReturnOriginalStringWhenValueIsNotNullNorWhitespace(string value)
        {
            var result = value.IfNullOrWhiteSpace(Replacement);

            Assert.AreEqual(value, result);
        }

        #endregion
    }
}
