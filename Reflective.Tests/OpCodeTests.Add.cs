using System;
using NUnit.Framework;

namespace Reflective.Tests
{
    public partial class OpCodeTests
    {
        [Test]
        public void Add() => Test(il => il.Add(), 0x58);
    }
}