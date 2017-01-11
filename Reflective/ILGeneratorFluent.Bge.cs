using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Bge(int labelIndex) => Emit(OpCodes.Bge, GetLabel(labelIndex));

        public ILGeneratorFluent Bge([NotNull] string labelName) => Emit(OpCodes.Bge, GetLabel(labelName));
    }
}