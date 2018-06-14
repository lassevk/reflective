using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void And() => Test(il => il.And(), 0x5f);
    }
}