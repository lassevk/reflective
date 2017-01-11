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
        public ByteGenerator Byte(int value)
        {
            _Bytes.Add((byte)(value & 0xff));
            return this;
        }

        [NotNull]
        public ByteGenerator Int32(int value) => Byte(value & 0xff).Byte((value >> 8) & 0xff).Byte((value >> 16) & 0xff).Byte((value >> 24) & 0xff);

        public byte[] ToArray() => _Bytes.ToArray();
    }
}