using System;
using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException
// ReSharper disable InconsistentNaming

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4_m1(v=vs.110).aspx")]
        public void Ldc_i4() => Test(il => il.Ldc_I4(0x12345678), b => b.Byte(0x20).Int32(0x12345678));
    }
}
