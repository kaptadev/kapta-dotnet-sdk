using System;
using System.Collections.Generic;
using Kapta.Utility;
using NUnit.Framework;

namespace Kapta.Tests.Utility
{
    [TestFixture]
    public class ValidatorTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void ThrowIfNullOrWhitespace_ShouldThrowException(string value)
        {
            Assert.That(() => Validator.ThrowIfNullOrWhitespace(value, "test"), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [TestCase("a")]
        [TestCase("abc")]
        [TestCase("1 2 3 ")]
        public void ThrowIfNullOrWhitespace_DoesNotThrow(string value)
        {
            Validator.ThrowIfNullOrWhitespace(value, "test");
            Assert.Pass();
        }

        [Test]
        public void ThrowIfNull_ShouldThrowException()
        {
            Assert.That(() => Validator.ThrowIfNull(null, "test"), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void ThrowIfNull_DoesNotThrow()
        {
            Validator.ThrowIfNull(new List<string>(), "test");
            Assert.Pass();
        }
    }
}
