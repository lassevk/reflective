﻿using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ldc_i4_S() => Test(il => il.Ldc_I4_S(0x23), 0x1f, 0x23);
    }
}