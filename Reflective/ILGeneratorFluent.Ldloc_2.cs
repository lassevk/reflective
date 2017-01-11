using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at index 2 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_2(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_2() => Emit(OpCodes.Ldloc_2);
    }
}