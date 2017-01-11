using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_6() => Test(il => il.Ldc_I4_6(), 0x1c);
    }
}