using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent Beq(int labelIndex) => Emit(OpCodes.Beq, GetLabel(labelIndex));

        [NotNull]
        public ILGeneratorFluent Beq([NotNull] string labelName) => Emit(OpCodes.Beq, GetLabel(labelName));
    }
}