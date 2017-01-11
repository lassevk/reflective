using System;
using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException
// ReSharper disable InconsistentNaming

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4() => Test(il => il.Ldc_I4(0x12345678), 0x20, 0x78, 0x56, 0x34, 0x12);
    }
}
