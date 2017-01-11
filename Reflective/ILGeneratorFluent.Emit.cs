using System;
using System.Reflection;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Puts the specified instruction onto the stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The Microsoft Intermediate Language (MSIL) instruction to be put onto the stream.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/csx7wsz2(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode)
        {
            _ILGenerator.Emit(opcode);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and character argument onto the Microsoft intermediate
        /// language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream.
        /// </param>
        /// <param name="arg"></param>
        /// <returns>
        /// The character argument pushed onto the stream immediately after the instruction.
        /// </returns>
        /// <see href="https://msdn.microsoft.com/en-us/library/yxe6yw80(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, byte arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and character argument onto the Microsoft intermediate
        /// language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream.
        /// </param>
        /// <param name="arg"></param>
        /// <returns>
        /// The character argument pushed onto the stream immediately after the instruction.
        /// </returns>
        /// <see href="https://msdn.microsoft.com/en-us/library/9td0364s(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, sbyte arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and metadata token for the specified constructor onto the
        /// Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="con">
        /// A <see cref="ConstructorInfo"/> representing a constructor.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/1h8y9503(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="con"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] ConstructorInfo con)
        {
            if (con == null)
                throw new ArgumentNullException(nameof(con));

            _ILGenerator.Emit(opcode, con);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream. Defined in the <see cref="OpCodes"/> enumeration.
        /// </param>
        /// <param name="arg">
        /// The numerical argument pushed onto the stream immediately after the instruction.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/8ycbsxxh(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, double arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream. Defined in the <see cref="OpCodes"/> enumeration.
        /// </param>
        /// <param name="arg">
        /// The numerical argument pushed onto the stream immediately after the instruction.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/system.reflection.emit.ilgenerator.emit(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, float arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the
        /// metadata token for the given string.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream. Defined in the <see cref="OpCodes"/> enumeration.
        /// </param>
        /// <param name="arg">
        /// The <see cref="String"/> to be emitted.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/yf2s00wd(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="arg"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] string arg)
        {
            if (arg == null)
                throw new ArgumentNullException(nameof(arg));

            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by
        /// the metadata token for the given type.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream. Defined in the <see cref="OpCodes"/> enumeration.
        /// </param>
        /// <param name="type">
        /// The <see cref="Type"/> to be emitted.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/yf2s00wd(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="type"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            _ILGenerator.Emit(opcode, type);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="field">
        /// A <see cref="FieldInfo"/> representing a field.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/dc657abw(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="field"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] FieldInfo field)
        {
            if (field == null)
                throw new ArgumentNullException(nameof(field));

            _ILGenerator.Emit(opcode, field);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream.
        /// </param>
        /// <param name="arg">
        /// The numerical argument pushed onto the stream immediately after the instruction.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/h3c68sh6(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, int arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be put onto the stream.
        /// </param>
        /// <param name="arg">
        /// The numerical argument pushed onto the stream immediately after the instruction.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/x3aeheba(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, long arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="arg">
        /// The <see cref="Int16"/> argument pushed onto the stream immediately after the instruction.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/3awhcx8t(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, short arg)
        {
            _ILGenerator.Emit(opcode, arg);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream and leaves space to
        /// include a label when fixes are done.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="label">
        /// The label to which to branch from this location.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/ahkzc1bh(v=vs.110).aspx"/>
        public ILGeneratorFluent Emit(OpCode opcode, Label label)
        {
            _ILGenerator.Emit(opcode, label);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream and leaves space to
        /// include all the labels when fixes are done.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="labels">
        /// The array of label objects to which to branch from this location. All of the labels will be used.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/ahkzc1bh(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="labels"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] Label[] labels)
        {
            if (labels == null)
                throw new ArgumentNullException(nameof(labels));

            _ILGenerator.Emit(opcode, labels);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the
        /// index of the given local variable.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="local">
        /// A local variable.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/h2725z44(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="local"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] LocalBuilder local)
        {
            if (local == null)
                throw new ArgumentNullException(nameof(local));

            _ILGenerator.Emit(opcode, local);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the
        /// metadata token for the given method.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="method">
        /// A <see cref="MethodInfo"/> representing a method.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/xz8067x2(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="method"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] MethodInfo method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            _ILGenerator.Emit(opcode, method);
            return this;
        }

        /// <summary>
        /// Puts the specified instruction and a signature token onto the Microsoft intermediate language (MSIL) stream of instructions.
        /// </summary>
        /// <param name="opcode">
        /// The MSIL instruction to be emitted onto the stream.
        /// </param>
        /// <param name="signature">
        /// A helper for constructing a signature token.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/h77x0fbt(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="signature"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Emit(OpCode opcode, [NotNull] SignatureHelper signature)
        {
            if (signature == null)
                throw new ArgumentNullException(nameof(signature));

            _ILGenerator.Emit(opcode, signature);
            return this;
        }
    }
}