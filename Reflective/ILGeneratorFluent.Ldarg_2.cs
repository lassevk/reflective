using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the argument at index 2 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldarg_2(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldarg_2() => Emit(OpCodes.Ldarg_2);
    }
}