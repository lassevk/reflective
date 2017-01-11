using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent Ldc_I4_5() => Emit(OpCodes.Ldc_I4_5);
    }
}