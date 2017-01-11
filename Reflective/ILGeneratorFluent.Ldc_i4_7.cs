using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pushes the integer value of 7 onto the evaluation stack as an <see cref="Int32"/>.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4_7(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldc_I4_7() => Emit(OpCodes.Ldc_I4_7);
    }
}