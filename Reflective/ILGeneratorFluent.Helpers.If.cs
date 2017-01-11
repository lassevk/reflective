using System;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// In-line "if" selection block, that executes either the <paramref name="trueFunc"/> or <paramref name="falseFunc"/>
        /// functions depending on the value of the <paramref name="expression"/>.
        /// </summary>
        /// <param name="expression">
        /// A <see cref="Boolean"/> expression used to determine if <paramref name="trueFunc"/> or <paramref name="falseFunc"/>
        /// should be executed.
        /// </param>
        /// <param name="trueFunc">
        /// The function delegate to execute if <paramref name="expression"/> is <c>true</c>.
        /// </param>
        /// <param name="falseFunc">
        /// The function delegate to execute if <paramref name="expression"/> is <c>false</c>,
        /// or <c>null</c> if no function should be executed in this case.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="trueFunc"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent If(bool expression, [NotNull] Func<ILGeneratorFluent, ILGeneratorFluent> trueFunc, [CanBeNull] Func<ILGeneratorFluent, ILGeneratorFluent> falseFunc = null)
        {
            var fluent = this;
            if (expression)
                fluent = trueFunc(fluent);
            else if (falseFunc != null)
                fluent = falseFunc(fluent);
            return fluent;
        }
    }
}