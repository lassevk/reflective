using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.stloc_3(v=vs.110).aspx"/>
        public ILGeneratorFluent Stloc_3() => Emit(OpCodes.Stloc_3);
    }
}