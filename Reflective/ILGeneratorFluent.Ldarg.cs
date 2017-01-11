using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads an argument (referenced by a specified index value) onto the stack.
        /// </summary>
        /// <param name="index">
        /// The index of the argument to load onto the stack. Note that for instance methods, the 0th argument is the
        /// <c>this</c> parameter.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldarg(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldarg(ushort index) => Emit(OpCodes.Ldarg, (short)index);
    }
}
