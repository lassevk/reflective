using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Add_Ovf() => Test(il => il.Add_Ovf(), 0xd6);
    }
}