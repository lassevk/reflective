using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent Ldc_I4_2() => Emit(OpCodes.Ldc_I4_2);
    }
}