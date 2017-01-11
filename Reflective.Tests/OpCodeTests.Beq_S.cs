using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Beq_S_Indexed() => Test(il => il.DefineLabel().Beq_S(0).MarkLabel(0), 0x2e, 0x00);

        [Test]
        public void Beq_S_Named() => Test(il => il.DefineLabel("test").Beq_S("test").MarkLabel("test"), 0x2e, 0x00);
    }
}