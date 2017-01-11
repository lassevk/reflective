using System.Reflection.Emit;
using JetBrains.Annotations;

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

        public ILGeneratorFluent Emit(OpCode opcode, short arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        public ILGeneratorFluent Emit(OpCode opcode, Label label)
        {
            _ILGenerator.Emit(opcode, label);
            return this;
        }
    }
}