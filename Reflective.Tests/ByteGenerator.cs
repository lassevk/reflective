using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Reflective.Tests
{
    internal class ByteGenerator
    {
        [NotNull]
        private readonly List<Byte> _Bytes = new List<byte>();

        [NotNull]
        public ByteGenerator Byte(byte value)
        {
            _Bytes.Add(value);
            return this;
        }

        [NotNull]
        public ByteGenerator Int32(int value) => Byte((byte)(value & 0xff)).Byte((byte)((value >> 8) & 0xff)).Byte((byte)((value >> 16) & 0xff)).Byte((byte)((value >> 24) & 0xff));

        public byte[] ToArray() => _Bytes.ToArray();
    }
}