using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Declares a new label and optionally gives it a name.
        /// </summary>
        /// <param name="name">
        /// The name to give the label, for use only within the current fluent interface context.
        /// </param>
        /// <remarks>
        /// <para>Labels defined are indexed starting at 0. Any fluent interface method that refers to a label can do so using either
        /// the 0-based index, which exists for all the labels defined through the interface, or the name of the
        /// label, providing one was specified when the label was declared.</para>
        /// <para>Note that any declared labels must also be marked in the instruction stream using <see cref="MarkLabel(int)"/> or
        /// <see cref="MarkLabel(string)"/>, specifying the actual location of the label. You can declare a variable and
        /// use it before it has been marked, but it <b>must</b> be marked.</para>
        /// </remarks>
        public ILGeneratorFluent DefineLabel(string name = null)
        {
            var lbl = _ILGenerator.DefineLabel();
            if (name != null)
                _LabelsByName.Add(name, lbl);
            _Labels.Add(lbl);
            return this;
        }
    }
}