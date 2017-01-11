using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_0() => Test(il => il.Ldc_I4_0(), 0x16);
    }
}