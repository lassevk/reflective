using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.and(v=vs.110).aspx")]
        public void And() => Test(il => il.And(), 0x5f);
    }
}