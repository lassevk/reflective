using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        /// <param name="localName">
        /// The name of the variable to load onto the evaluation stack. The variable has to have been defined using
        /// <see cref="DefineLabel"/> specifying a name for it.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_s(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_S([NotNull] string localName) => Ldloc_S(GetLocal(localName));

        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        /// <param name="local">
        /// The <see cref="LocalBuilder"/> variable to load onto the evaluation stack.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_s(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_S([NotNull] LocalBuilder local) => Emit(OpCodes.Ldloc_S, local);

        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack, short form.
        /// </summary>
        /// <param name="index">
        /// The index of the local to load onto the evaluation stack.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.ldloc_s(v=vs.110).aspx"/>
        public ILGeneratorFluent Ldloc_S(ushort index) => Emit(OpCodes.Ldloc_S, (short)index);
    }
}