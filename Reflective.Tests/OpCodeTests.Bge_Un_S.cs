using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Bge_Un_S_Indexed() => Test(il => il.DefineLabel().Bge_Un_S(0).MarkLabel(0), 0x34, 0x00);

        [Test]
        public void Bge_Un_S_Named() => Test(il => il.DefineLabel("test").Bge_Un_S("test").MarkLabel("test"), 0x34, 0x00);
    }
}