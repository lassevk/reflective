using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.stloc_0(v=vs.110).aspx"/>
        public ILGeneratorFluent Stloc_0() => Emit(OpCodes.Stloc_0);
    }
}