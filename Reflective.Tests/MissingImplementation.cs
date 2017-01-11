using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using NUnit.Framework;

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    [TestFixture]
    public class MissingImplementation
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            foreach (var value in typeof(OpCodes).GetFields())
                yield return new TestCaseData(value.Name).SetName(value.Name);
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void ImplementationExists(string opcode)
        {
            bool implementationExists = typeof(ILGeneratorFluent).GetMethod(opcode) != null;
            Assert.That(implementationExists);
        }
    }
}
