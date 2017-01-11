using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_5() => Test(il => il.Ldc_I4_5(), 0x1b);
    }
}