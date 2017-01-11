using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        /// <summary>
        /// Iterates over the given collection, executing the <paramref name="itemFunc"/> once for each item.
        /// </summary>
        /// <typeparam name="T">
        /// The type of elements in the collection.
        /// </typeparam>
        /// <param name="collection">
        /// The collection to iterate over.
        /// </param>
        /// <param name="itemFunc">
        /// The function delegate to execute for each item of <paramref name="collection"/>.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="collection"/> is <c>null</c>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="itemFunc"/> is <c>null</c>.</para>
        /// </exception>
        public ILGeneratorFluent Foreach<T>([NotNull] IEnumerable<T> collection, [NotNull] Func<ILGeneratorFluent, T, ILGeneratorFluent> itemFunc)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (itemFunc == null)
                throw new ArgumentNullException(nameof(itemFunc));

            var fluent = this;
            foreach (var element in collection)
                fluent = itemFunc(fluent, element);
            return fluent;
        }
    }
}