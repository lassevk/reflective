using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent Ldc_I4_S(byte arg) => Emit(OpCodes.Ldc_I4_S, arg);
    }
}