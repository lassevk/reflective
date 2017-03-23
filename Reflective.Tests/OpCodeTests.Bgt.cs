using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Bgt_Indexed() => Test(il => il.DefineLabel().Bgt(0).MarkLabel(0), 0x3d, 0x00, 0x00, 0x00, 0x00);

        [Test]
        public void Bgt_Named() => Test(il => il.DefineLabel("test").Bgt("test").MarkLabel("test"), 0x3d, 0x00, 0x00, 0x00, 0x00);
    }
}
