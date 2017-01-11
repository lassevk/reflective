using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldc_I4_S(byte arg) => Emit(OpCodes.Ldc_I4_S, arg);
    }
}