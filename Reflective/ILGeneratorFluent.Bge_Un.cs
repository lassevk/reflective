using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Bge_Un(int labelIndex) => Emit(OpCodes.Bge_Un, GetLabel(labelIndex));

        public ILGeneratorFluent Bge_Un([NotNull] string labelName) => Emit(OpCodes.Bge_Un, GetLabel(labelName));
    }
}