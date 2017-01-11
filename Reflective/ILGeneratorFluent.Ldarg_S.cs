using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads the argument (referenced by a specified short form index) onto the evaluation stack.
        /// </summary>
        /// <param name="index">
        /// The index of the argument to load onto the stack. Note that for instance methods, the 0th argument is the
        /// <c>this</c> parameter.
        /// </param>
        /// <returns></returns>
        public ILGeneratorFluent Ldarg_S(byte index) => Emit(OpCodes.Ldarg_S, index);
    }
}