﻿using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_1() => Test(il => il.Ldc_I4_1(), 0x17);
    }
}