using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldarg_1() => Emit(OpCodes.Ldarg_1);
    }
}