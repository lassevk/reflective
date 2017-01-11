using System;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public static class ILGeneratorExtensions
    {
        public static ILGeneratorFluent ToFluent([NotNull] this ILGenerator ilGenerator) => new ILGeneratorFluent(ilGenerator);
    }
}
