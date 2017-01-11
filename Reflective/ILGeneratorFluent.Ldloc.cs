using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        /// <param name="localName">
        /// The name of the variable to load onto the evaluation stack. The variable has to have been defined using
        /// <see cref="DefineLabel"/> specifying a name for it.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc([NotNull] string localName) => Ldloc(GetLocal(localName));

        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        /// <param name="local">
        /// The <see cref="LocalBuilder"/> variable to load onto the evaluation stack.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc([NotNull] LocalBuilder local) => Emit(OpCodes.Ldloc, local);

        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack.
        /// </summary>
        /// <param name="index">
        /// The index of the local to load onto the evaluation stack.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc(ushort index) => Emit(OpCodes.Ldloc, (short)index);
    }
}