using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming

namespace Reflective
{
    internal static class ReSharperHelpers
    {
        // ReSharper disable ParameterOnlyUsedForPreconditionCheck.Global
        [Conditional("DEBUG")]
        [ContractAnnotation("expression:false => halt")]
        internal static void assume(bool expression, [CallerFilePath] string callerFilePath = null, [CallerMemberName] string callerMemberName = null, [CallerLineNumber] int callerLineNumber = 0)
        {
            Debug.Assert(expression, $"Assumption did not hold in {callerMemberName} in {callerFilePath}#{callerLineNumber}");
        }
        // ReSharper restore ParameterOnlyUsedForPreconditionCheck.Global
    }
}
