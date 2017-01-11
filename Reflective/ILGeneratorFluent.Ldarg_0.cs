using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldarg_0() => Emit(OpCodes.Ldarg_0);
    }
}