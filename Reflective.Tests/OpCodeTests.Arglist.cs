using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.arglist(v=vs.110).aspx")]
        public void Arglist() => Test(il => il.Arglist(), 0xfe, 0x00);
    }
}