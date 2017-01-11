namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Loads an argument (referenced by a specified index value) onto the stack,
        /// picking the optimal opcode to use depending on the index value.
        /// </summary>
        /// <param name="index">
        /// The index of the argument to load onto the stack. Note that for instance methods, the 0th argument is the
        /// <c>this</c> parameter.
        /// </param>
        public ILGeneratorFluent Ldarg_Opt(ushort index)
        {
            switch (index)
            {
                case 0:
                    return Ldarg_0();

                case 1:
                    return Ldarg_1();

                case 2:
                    return Ldarg_2();

                case 3:
                    return Ldarg_3();
            }

            if (index <= 255)
                return Ldarg_S((byte)index);

            return Ldarg(index);
        }
    }
}