using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add_ovf_un(v=vs.110).aspx")]
        public void Add_Ovf_Un() => Test(il => il.Add_Ovf_Un(), 0xd7);
    }
}