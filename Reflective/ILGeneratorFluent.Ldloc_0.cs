using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at index 0 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_0(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_0() => Emit(OpCodes.Ldloc_0);
    }
}