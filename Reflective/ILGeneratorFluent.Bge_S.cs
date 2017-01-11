using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
        /// </summary>
        /// <param name="labelIndex">
        /// The 0-based index of the label to branch to. The label must have been defined by <see cref="DefineLabel"/>.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.bge_s(v=vs.110).aspx"/>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="labelIndex"/> contains an invalid index, either negative or too high a value specified.</para>
        /// </exception>
        public ILGeneratorFluent Bge_S(int labelIndex) => Emit(OpCodes.Bge_S, GetLabel(labelIndex));

        /// <summary>
        /// Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
        /// </summary>
        /// <param name="labelName">
        /// The name of the label to branch to. The label must have been defined by <see cref="DefineLabel"/>.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.opcodes.bge_s(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="labelName"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Bge_S([NotNull] string labelName) => Emit(OpCodes.Bge_S, GetLabel(labelName));
    }
}