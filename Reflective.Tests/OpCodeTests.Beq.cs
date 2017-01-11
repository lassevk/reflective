﻿using NUnit.Framework;

// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx")]
        public void Beq_Indexed() => Test(il => il.DefineLabel().Beq(0), b => b.Byte(0x3b).Int32(-5));

        [Test, Documentation("https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx")]
        public void Beq_Named() => Test(il => il.DefineLabel("test").Beq("test"), b => b.Byte(0x3b).Int32(-5));
    }
}