using System;
using System.Reflection;
using System.Reflection.Emit;
using NUnit.Framework;

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable PossibleNullReferenceException

namespace Reflective.Tests
{
    [TestFixture]
    public partial class OpCodeTests
    {
        private void Test(Func<ILGeneratorFluent, ILGeneratorFluent> builder, params byte[] expected)
        {
            var assemblyName = new AssemblyName("DummyAssembly");
            var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName.Name, assemblyName.Name + ".dll");
            var typeBuilder = moduleBuilder.DefineType("DummyClass");

            var methodBuilder = typeBuilder.DefineMethod("DummyMethod", MethodAttributes.Public);

            builder(methodBuilder.GetILGenerator().ToFluent());

            var type = typeBuilder.CreateType();
            var method = type.GetMethod("DummyMethod");

            // Note! The method is most likely invalid at this point as no attempt has been made to balance the stack
            var bytes = method.GetMethodBody().GetILAsByteArray();
            CollectionAssert.AreEqual(expected, bytes);
        }
    }
}
