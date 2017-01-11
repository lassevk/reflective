using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

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
