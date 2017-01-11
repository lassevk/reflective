using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Add_Ovf_Un() => Test(il => il.Add_Ovf_Un(), 0xd7);
    }
}