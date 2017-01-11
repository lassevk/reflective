using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldarg_3() => Emit(OpCodes.Ldarg_3);
    }
}