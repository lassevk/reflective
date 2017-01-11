using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_3() => Test(il => il.Ldc_I4_3(), 0x19);
    }
}