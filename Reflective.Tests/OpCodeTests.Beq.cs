using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx")]
        public void Beq() => Test(il => il.DefineLabel().Beq(0), b => b.Byte(0x3b).Int32(-5));
    }
}