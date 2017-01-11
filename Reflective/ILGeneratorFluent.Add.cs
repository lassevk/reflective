using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Adds two values and pushes the result onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add(v=vs.110).aspx"/>
        public ILGeneratorFluent Add() => Emit(OpCodes.Add);
    }
}