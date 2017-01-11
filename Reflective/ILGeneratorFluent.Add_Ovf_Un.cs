using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent Add_Ovf_Un() => Emit(OpCodes.Add_Ovf_Un);
    }
}