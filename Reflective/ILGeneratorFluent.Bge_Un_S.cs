using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Bge_Un_S(int labelIndex) => Emit(OpCodes.Bge_Un_S, GetLabel(labelIndex));

        public ILGeneratorFluent Bge_Un_S([NotNull] string labelName) => Emit(OpCodes.Bge_Un_S, GetLabel(labelName));
    }
}