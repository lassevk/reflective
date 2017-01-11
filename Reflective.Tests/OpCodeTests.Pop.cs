using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.pop(v=vs.110).aspx")]
        public void Pop() => Test(il => il.Pop(), 0x26);
    }
}