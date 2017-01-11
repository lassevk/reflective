using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Add_Ovf() => Emit(OpCodes.Add_Ovf);
    }
}