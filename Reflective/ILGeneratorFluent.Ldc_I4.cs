using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pushes a supplied value of type <see cref="Int32"/> onto the evaluation stack as an <see cref="Int32"/>.
        /// </summary>
        /// <param name="arg">
        /// The value to push onto the stack.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldc_i4(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldc_I4(int arg) => Emit(OpCodes.Ldc_I4, arg);
    }
}