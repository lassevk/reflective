using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pushes the integer value of 5 onto the evaluation stack as an <see cref="Int32"/>.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4_5(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldc_I4_5() => Emit(OpCodes.Ldc_I4_5);
    }
}