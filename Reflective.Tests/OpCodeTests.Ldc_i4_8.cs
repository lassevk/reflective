using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4_8(v=vs.110).aspx")]
        public void Ldc_i4_8() => Test(il => il.Ldc_I4_8(), 0x1e);
    }
}