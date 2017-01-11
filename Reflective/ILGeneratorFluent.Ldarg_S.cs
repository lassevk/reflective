using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldarg_S(byte index) => Emit(OpCodes.Ldarg_S, index);
    }
}