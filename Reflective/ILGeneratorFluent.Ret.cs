using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Returns from the current method, pushing a return value (if present) from the callee's evaluation
        /// stack onto the caller's evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ret(v=vs.110).aspx"/>
        public ILGeneratorFluent Ret() => Emit(OpCodes.Ret);
    }
}