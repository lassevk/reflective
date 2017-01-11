using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.bge(v=vs.110).aspx")]
        public void Bge_Indexed() => Test(il => il.DefineLabel().Bge(0).MarkLabel(0), 0x3c, 0x00, 0x00, 0x00, 0x00);

        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.bge(v=vs.110).aspx")]
        public void Bge_Named() => Test(il => il.DefineLabel("test").Bge("test").MarkLabel("test"), 0x3c, 0x00, 0x00, 0x00, 0x00);
    }
}