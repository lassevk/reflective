using System;
using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldarg(ushort index) => Emit(OpCodes.Ldarg, (short)index);
    }
}
