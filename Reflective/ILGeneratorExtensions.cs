using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    /// <summary>
    /// Extension methods for <see cref="ILGenerator"/>.
    /// </summary>
    public static class ILGeneratorExtensions
    {
        /// <summary>
        /// Wraps the specified <see cref="ILGenerator"/> into a <see cref="ILGeneratorFluent"/>
        /// to provide a fluent interface for it.
        /// </summary>
        /// <param name="ilGenerator">
        /// The <see cref="ILGenerator"/> to provide a fluent interface for.
        /// </param>
        /// <returns>
        /// An instance of <see cref="ILGeneratorFluent"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="ilGenerator"/> is <c>null</c>.</para>
        /// </exception>
        public static ILGeneratorFluent ToFluent([NotNull] this ILGenerator ilGenerator) => new ILGeneratorFluent(ilGenerator);
    }
}
