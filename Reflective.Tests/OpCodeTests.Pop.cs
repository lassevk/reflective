using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Pop() => Test(il => il.Pop(), 0x26);
    }
}