using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Beq_Indexed() => Test(il => il.DefineLabel().Beq(0).MarkLabel(0), 0x3b, 0x00, 0x00, 0x00, 0x00);

        [Test]
        public void Beq_Named() => Test(il => il.DefineLabel("test").Beq("test").MarkLabel("test"), 0x3b, 0x00, 0x00, 0x00, 0x00);
    }
}