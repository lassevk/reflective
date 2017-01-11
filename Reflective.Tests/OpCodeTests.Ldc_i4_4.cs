using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_4() => Test(il => il.Ldc_I4_4(), 0x1a);
    }
}