using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add_ovf(v=vs.110).aspx")]
        public void Add_Ovf() => Test(il => il.Add_Ovf(), 0xd6);
    }
}