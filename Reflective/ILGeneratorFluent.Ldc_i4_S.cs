using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pushes the supplied <see cref="Byte"/> value onto the evaluation stack as an <see cref="Int32"/>, short form.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4_s(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldc_I4_S(byte arg) => Emit(OpCodes.Ldc_I4_S, arg);
    }
}