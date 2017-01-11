using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void DefineLabel() => Test(il => il.DefineLabel().Ret(), 0x2a);
    }
}