using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the argument at index 3 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldarg_3(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldarg_3() => Emit(OpCodes.Ldarg_3);
    }
}