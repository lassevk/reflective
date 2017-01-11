using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        private readonly ILGenerator _ILGenerator;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILGeneratorFluent([NotNull] ILGenerator ilGenerator)
        {
            if (ilGenerator == null)
                throw new ArgumentNullException(nameof(ilGenerator));

            _ILGenerator = ilGenerator;
        }
    }
}