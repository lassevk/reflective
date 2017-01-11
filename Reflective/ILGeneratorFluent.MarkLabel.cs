using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent MarkLabel(int index)
        {
            _ILGenerator.MarkLabel(GetLabel(index));
            return this;
        }

        public ILGeneratorFluent MarkLabel([NotNull] string name)
        {
            _ILGenerator.MarkLabel(GetLabel(name));
            return this;
        }
    }
}