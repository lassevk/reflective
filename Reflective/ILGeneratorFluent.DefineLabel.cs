using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        public ILGeneratorFluent DefineLabel(string name = null)
        {
            var lbl = _ILGenerator.DefineLabel();
            _ILGenerator.MarkLabel(lbl);
            if (name != null)
                _LabelsByName.Add(name, lbl);
            _Labels.Add(lbl);
            return this;
        }
    }
}