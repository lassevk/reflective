using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldc_I4_3() => Emit(OpCodes.Ldc_I4_3);
    }
}