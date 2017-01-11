using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        private readonly ILGenerator _ILGenerator;

        [NotNull]
        private readonly Dictionary<string, Label> _LabelsByName;

        [NotNull]
        private readonly List<Label> _Labels;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILGeneratorFluent([NotNull] ILGenerator ilGenerator)
        {
            if (ilGenerator == null)
                throw new ArgumentNullException(nameof(ilGenerator));

            _ILGenerator = ilGenerator;
            _LabelsByName = new Dictionary<string, Label>();
            _Labels = new List<Label>();
        }

        private Label GetLabel([NotNull] string name) => _LabelsByName[name];
        private Label GetLabel(int index) => _Labels[index];
    }
}