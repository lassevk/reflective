using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx")]
        public void Beq_S_Indexed() => Test(il => il.DefineLabel().Beq_S(0), b => b.Byte(0x2e).Byte(-2));

        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx")]
        public void Beq_S_Named() => Test(il => il.DefineLabel("test").Beq_S("test"), b => b.Byte(0x2e).Byte(-2));
    }
}