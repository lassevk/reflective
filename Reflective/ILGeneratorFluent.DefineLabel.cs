using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent DefineLabel(string name = null)
        {
            var lbl = _ILGenerator.DefineLabel();
            if (name != null)
                _LabelsByName.Add(name, lbl);
            _Labels.Add(lbl);
            return this;
        }
    }
}