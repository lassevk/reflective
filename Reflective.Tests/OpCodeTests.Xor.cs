using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Xor() => Test(il => il.Xor(), 0x61);
    }
}
