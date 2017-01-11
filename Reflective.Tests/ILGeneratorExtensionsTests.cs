using System;
using NUnit.Framework;

// ReSharper disable AssignNullToNotNullAttribute

namespace Reflective.Tests
{
    [TestFixture]
    public class ILGeneratorExtensionsTests
    {
        [Test]
        public void ToFluent_NullILGenerator_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ILGeneratorExtensions.ToFluent(null));
        }
    }
}
