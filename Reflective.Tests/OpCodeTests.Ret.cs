using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ret(v=vs.110).aspx")]
        public void Ret() => Test(il => il.Ret(), 0x2a);
    }
}