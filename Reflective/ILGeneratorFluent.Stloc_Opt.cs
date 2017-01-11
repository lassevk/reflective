using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index,
        /// picking the optimal "Stloc_X" opcode depending on the index of the specified local.
        /// </summary>
        /// <param name="name">
        /// The name of the local to store the value into.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="name"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Stloc_Opt([NotNull] string name) => Stloc(GetLocal(name));

        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index,
        /// picking the optimal "Stloc_X" opcode depending on the index value.
        /// </summary>
        /// <param name="local">
        /// The <see cref="LocalBuilder"/> local to store the value into.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="local"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Stloc_Opt([NotNull] LocalBuilder local) => Emit(OpCodes.Stloc, local);

        /// <summary>
        /// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index,
        /// picking the optimal "Stloc_X" opcode depending on the index value.
        /// </summary>
        /// <param name="index">
        /// The index of the local to store the value into.
        /// </param>
        public ILGeneratorFluent Stloc_Opt(ushort index)
        {
            switch (index)
            {
                case 0:
                    return Stloc_0();

                case 1:
                    return Stloc_1();

                case 2:
                    return Stloc_2();

                case 3:
                    return Stloc_3();
            }

            if (index <= 255)
                return Stloc_S((byte)index);

            return Stloc(index);
        }
    }
}
