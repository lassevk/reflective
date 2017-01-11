using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Beq(int labelIndex) => Emit(OpCodes.Beq, GetLabel(labelIndex));

        public ILGeneratorFluent Beq([NotNull] string labelName) => Emit(OpCodes.Beq, GetLabel(labelName));
    }
}