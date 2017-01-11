using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Bge_Un_Indexed() => Test(il => il.DefineLabel().Bge_Un(0).MarkLabel(0), 0x41, 0x00, 0x00, 0x00, 0x00);

        [Test]
        public void Bge_Un_Named() => Test(il => il.DefineLabel("test").Bge_Un("test").MarkLabel("test"), 0x41, 0x00, 0x00, 0x00, 0x00);
    }
}