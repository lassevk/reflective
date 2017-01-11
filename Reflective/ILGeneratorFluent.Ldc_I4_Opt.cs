using System;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Pushes a supplied value of type <see cref="Int32"/> onto the evaluation stack as an <see cref="Int32"/>,
        /// picking the optimal opcode depending the size and range of the value.
        /// </summary>
        /// <param name="value">
        /// The value to push onto the stack.
        /// </param>
        public ILGeneratorFluent Ldc_I4_Opt(int value)
        {
            switch (value)
            {
                case -1:
                    return Ldc_I4_M1();

                case 0:
                    return Ldc_I4_0();

                case 1:
                    return Ldc_I4_1();

                case 2:
                    return Ldc_I4_2();

                case 3:
                    return Ldc_I4_3();

                case 4:
                    return Ldc_I4_4();

                case 5:
                    return Ldc_I4_5();

                case 6:
                    return Ldc_I4_6();

                case 7:
                    return Ldc_I4_7();

                case 8:
                    return Ldc_I4_8();
            }

            if (value >= 0 && value <= 255)
                return Ldc_I4_S((byte)value);

            return Ldc_I4(value);
        }
    }
}
