using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Ldc_I4(int arg) => Emit(OpCodes.Ldc_I4, arg);
    }
}