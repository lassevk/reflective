using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Reflective
{
    /// <summary>
    /// This struct encapsulates a <see cref="ILGenerator"/> and provides a fluent interface for it.
    /// </summary>
    public partial struct ILGeneratorFluent
    {
        [NotNull]
        private readonly ILGenerator _ILGenerator;

        [NotNull]
        private readonly Dictionary<string, Label> _LabelsByName;

        [NotNull]
        private readonly List<Label> _Labels;

        [NotNull, ItemNotNull]
        private readonly Dictionary<string, LocalBuilder> _LocalsByName;

        [NotNull, ItemNotNull]
        private readonly List<LocalBuilder> _Locals;

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
            if (ilGenerator == null)
                throw new ArgumentNullException(nameof(ilGenerator));

            _ILGenerator = ilGenerator;
            _LabelsByName = new Dictionary<string, Label>();
            _Labels = new List<Label>();
            _LocalsByName = new Dictionary<string, LocalBuilder>();
            _Locals = new List<LocalBuilder>();
        }

        private Label GetLabel([NotNull] string name) => _LabelsByName[name];
        private Label GetLabel(int index) => _Labels[index];

        [NotNull]
        private LocalBuilder GetLocal([NotNull] string name) => _LocalsByName[name];

        [NotNull]
        private LocalBuilder GetLocal(int index) => _Locals[index];
    }
}