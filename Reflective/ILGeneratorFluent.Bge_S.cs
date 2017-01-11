using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Bge_S(int labelIndex) => Emit(OpCodes.Bge_S, GetLabel(labelIndex));

        public ILGeneratorFluent Bge_S([NotNull] string labelName) => Emit(OpCodes.Bge_S, GetLabel(labelName));
    }
}