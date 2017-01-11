using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Reflective
{
    public partial struct ILGeneratorFluent
    {
        [NotNull]
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