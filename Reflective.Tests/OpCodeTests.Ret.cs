using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Ret() => Test(il => il.Ret(), 0x2a);
    }
}