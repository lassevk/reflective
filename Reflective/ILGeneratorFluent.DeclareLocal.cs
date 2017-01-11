using System;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Declares a local variable of the specified type.
        /// </summary>
        /// <param name="type">
        /// A Type object that represents the type of the local variable.
        /// </param>
        /// <param name="name">
        /// An optional name to be used within the given fluent interface context.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/y1xffef4(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="type"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent DeclareLocal([NotNull] Type type, string name = null)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            var local = _ILGenerator.DeclareLocal(type);
            if (name != null)
                _LocalsByName.Add(name, local);

            return this;
        }

        /// <summary>
        /// Declares a local variable of the specified type, pinning the object referred to by the variable.
        /// </summary>
        /// <param name="type">
        /// A Type object that represents the type of the local variable.
        /// </param>
        /// <param name="name">
        /// An optional name to be used within the given fluent interface context.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/184fx29k(v=vs.110).aspx"/>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="type"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent DeclarePinningLocal([NotNull] Type type, string name = null)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            var local = _ILGenerator.DeclareLocal(type, true);
            if (name != null)
                _LocalsByName.Add(name, local);

            return this;
        }

        /// <summary>
        /// Declares a local variable of the specified type.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the local variable.
        /// </typeparam>
        /// <param name="name">
        /// An optional name to be used within the given fluent interface context.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/y1xffef4(v=vs.110).aspx"/>
        public ILGeneratorFluent DeclareLocal<T>(string name = null) => DeclareLocal(typeof(T), name);

        /// <summary>
        /// Declares a local variable of the specified type, pinning the object referred to by the variable.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the local variable.
        /// </typeparam>
        /// <param name="name">
        /// An optional name to be used within the given fluent interface context.
        /// </param>
        /// <see href="https://msdn.microsoft.com/en-us/library/184fx29k(v=vs.110).aspx"/>
        public ILGeneratorFluent DeclarePinningLocal<T>(string name = null) => DeclarePinningLocal(typeof(T), name);
    }
}