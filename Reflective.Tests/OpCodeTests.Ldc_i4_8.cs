using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_8() => Test(il => il.Ldc_I4_8(), 0x1e);
    }
}