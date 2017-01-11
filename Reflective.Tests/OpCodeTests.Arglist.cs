using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Arglist() => Test(il => il.Arglist(), 0xfe, 0x00);
    }
}