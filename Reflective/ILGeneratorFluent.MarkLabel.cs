using System;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Marks the Microsoft intermediate language (MSIL) stream's current position with the given label.
        /// </summary>
        /// <param name="index">
        /// The index of the label to record the position of.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.ilgenerator.marklabel(v=vs.110).aspx"/>
        public ILGeneratorFluent MarkLabel(int index)
        {
            _ILGenerator.MarkLabel(GetLabel(index));
            return this;
        }

        /// <summary>
        /// Marks the Microsoft intermediate language (MSIL) stream's current position with the given label.
        /// </summary>
        /// <param name="name">
        /// The name of the label to record the position of. The label has to have been declared using
        /// <see cref="DefineLabel"/>, specifying a name.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.ilgenerator.marklabel(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="name"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent MarkLabel([NotNull] string name)
        {
            _ILGenerator.MarkLabel(GetLabel(name));
            return this;
        }
    }
}