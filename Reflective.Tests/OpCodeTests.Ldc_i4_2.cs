﻿using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_2() => Test(il => il.Ldc_I4_2(), 0x18);
    }
}