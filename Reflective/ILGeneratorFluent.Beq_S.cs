using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent Beq_S(int labelIndex) => Emit(OpCodes.Beq_S, GetLabel(labelIndex));

        [NotNull]
        public ILGeneratorFluent Beq_S([NotNull] string labelName) => Emit(OpCodes.Beq_S, GetLabel(labelName));
    }
}