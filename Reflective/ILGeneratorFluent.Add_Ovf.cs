using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Add_Ovf() => Emit(OpCodes.Add_Ovf);
    }
}