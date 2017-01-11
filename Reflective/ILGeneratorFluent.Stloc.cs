using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        /// <param name="localName">
        /// The name of the local to store the value into. The local has to have been declared using
        /// <see cref="DeclareLocal"/> specifying a name.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.stloc(v=vs.110).aspx"/>
        public ILGeneratorFluent Stloc([NotNull] string localName) => Stloc(GetLocal(localName));

        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        /// <param name="index">
        /// The index of the local to store the value into.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.stloc(v=vs.110).aspx"/>
        public ILGeneratorFluent Stloc(ushort index) => Emit(OpCodes.Stloc, (short)index);

        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
        /// </summary>
        /// <param name="local">
        /// The <see cref="LocalBuilder"/> local to store the value into.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.stloc(v=vs.110).aspx"/>
        public ILGeneratorFluent Stloc([NotNull] LocalBuilder local) => Emit(OpCodes.Stloc, local);
    }
}