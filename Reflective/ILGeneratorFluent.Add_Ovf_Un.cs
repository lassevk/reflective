using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.add_ovf_un(v=vs.110).aspx"/>
        public ILGeneratorFluent Add_Ovf_Un() => Emit(OpCodes.Add_Ovf_Un);
    }
}