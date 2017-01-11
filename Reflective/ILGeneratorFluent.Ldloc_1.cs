using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at index 1 onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_1(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_1() => Emit(OpCodes.Ldloc_1);
    }
}