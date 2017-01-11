using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Bge_S_Indexed() => Test(il => il.DefineLabel().Bge_S(0).MarkLabel(0), 0x2f, 0x00);

        [Test]
        public void Bge_S_Named() => Test(il => il.DefineLabel("test").Bge_S("test").MarkLabel("test"), 0x2f, 0x00);
    }
}