using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

using static Reflective.ReSharperHelpers;

namespace Reflective
{
    /// <summary>
    /// This struct encapsulates a <see cref="ILGenerator"/> and provides a fluent interface for it.
    /// </summary>
    [PublicAPI]
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        private readonly ILGenerator _ILGenerator;

        [NotNull]
        private readonly Dictionary<string, Label> _LabelsByName;

        [NotNull]
        private readonly List<Label> _Labels;

        [NotNull]
        private readonly Dictionary<string, LocalBuilder> _LocalsByName;

        /// <summary>
        /// Constructs a new instance of <see cref="ILGeneratorFluent"/> around the specified <see cref="ILGenerator"/>.
        /// </summary>
        /// <param name="ilGenerator">
        /// The <see cref="ILGenerator"/> instance to provide a fluent interface for.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="ilGenerator"/> is <c>null</c>.</para>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILGeneratorFluent([NotNull] ILGenerator ilGenerator)
        {
            _ILGenerator = ilGenerator ?? throw new ArgumentNullException(nameof(ilGenerator));
            _LabelsByName = new Dictionary<string, Label>();
            _Labels = new List<Label>();
            _LocalsByName = new Dictionary<string, LocalBuilder>();
        }

        private Label GetLabel([NotNull] string name) => _LabelsByName[name];
        private Label GetLabel(int index) => _Labels[index];

        [NotNull]
        private LocalBuilder GetLocal([NotNull] string name)
        {
            assume(_LocalsByName[name] != null);
            return _LocalsByName[name];
        }
    }
}