using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Arglist() => Emit(OpCodes.Arglist);
    }
}