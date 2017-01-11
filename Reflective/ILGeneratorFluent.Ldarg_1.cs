using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the argument at index 1 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldarg_1(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldarg_1() => Emit(OpCodes.Ldarg_1);
    }
}