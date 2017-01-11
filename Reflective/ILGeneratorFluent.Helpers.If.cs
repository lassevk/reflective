using System;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
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