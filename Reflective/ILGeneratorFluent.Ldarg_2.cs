using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldarg_2() => Emit(OpCodes.Ldarg_2);
    }
}