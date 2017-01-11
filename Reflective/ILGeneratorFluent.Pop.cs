using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Removes the value currently on top of the evaluation stack
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.pop(v=vs.110).aspx"/>
        public ILGeneratorFluent Pop() => Emit(OpCodes.Pop);
    }
}