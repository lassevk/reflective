using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at index 3 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_3(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_3() => Emit(OpCodes.Ldloc_3);
    }
}