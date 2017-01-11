using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx")]
        public void Add() => Test(il => il.Add(), 0x58);
    }
}