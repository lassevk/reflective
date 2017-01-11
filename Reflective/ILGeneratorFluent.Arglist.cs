using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Returns an unmanaged pointer to the argument list of the current method.
        /// </summary>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.arglist(v=vs.110).aspx"/>
        public ILGeneratorFluent Arglist() => Emit(OpCodes.Arglist);
    }
}