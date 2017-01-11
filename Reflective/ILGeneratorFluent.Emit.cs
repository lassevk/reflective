using System.Reflection.Emit;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        public ILGeneratorFluent Emit(OpCode opcode)
        {
            _ILGenerator.Emit(opcode);
            return this;
        }

        public ILGeneratorFluent Emit(OpCode opcode, byte arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        public ILGeneratorFluent Emit(OpCode opcode, int arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }
    }
}