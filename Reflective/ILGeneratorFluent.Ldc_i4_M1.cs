using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldc_I4_M1() => Emit(OpCodes.Ldc_I4_M1);
    }
}