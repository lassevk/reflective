namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
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