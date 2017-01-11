using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pushes the integer value of 1 onto the evaluation stack as an <see cref="Int32"/>.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4_1(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldc_I4_1() => Emit(OpCodes.Ldc_I4_1);
    }
}