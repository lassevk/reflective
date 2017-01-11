using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack,
        /// picking the optimal "Stloc_X" opcode depending on the index of the specified local.
        /// </summary>
        /// <param name="name">
        /// The name of the variable to load onto the evaluation stack. The variable has to have been defined using
        /// <see cref="DefineLabel"/> specifying a name for it.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="name"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Ldloc_Opt([NotNull] string name) => Ldloc(GetLocal(name));

        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack,
        /// picking the optimal "Stloc_X" opcode depending on the index of the specified local.
        /// </summary>
        /// <param name="local">
        /// The <see cref="LocalBuilder"/> variable to load onto the evaluation stack.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="local"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Ldloc_Opt([NotNull] LocalBuilder local) => Emit(OpCodes.Ldloc, local);

        /// <summary>
        /// Loads the local variable at a specific index onto the evaluation stack,
        /// picking the optimal "Stloc_X" opcode depending on the index of the specified local.
        /// </summary>
        /// <param name="index">
        /// The index of the local to load onto the evaluation stack.
        /// </param>
        public ILGeneratorFluent Ldloc_Opt(ushort index)
        {
            switch (index)
            {
                case 0:
                    return Ldloc_0();

                case 1:
                    return Ldloc_1();

                case 2:
                    return Ldloc_2();

                case 3:
                    return Ldloc_3();
            }

            if (index <= 255)
                return Ldloc_S((byte)index);

            return Ldloc(index);
        }
    }
}