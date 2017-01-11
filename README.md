# reflective

This library introduces ILGenerator extension methods and wrapper types that makes it a bit more fluent to
write IL code in your .NET programs.

# Example

Given this code you want to emit:

    return arg0 + arg1 + 1234;

Instead of this:

    ILGenerator il = ....;
    il.Emit(OpCodes.Ldarg_0);
    il.Emit(OpCodes.Ldarg_1);
    il.Emit(OpCodes.Add);
    il.Emit(OpCodes.Ldc_I4, 1234);
    il.Emit(OpCodes.Add);
    il.Emit(OpCodes.Ret);
    
You can do this:

    ILGeneratorFluent il = (....).ToFluent();
    il
        .Ldarg_0()
        .Ldarg_1()
        .Add()
        .Ldc_I4(1234)
        .Add()
        .Ret();

The fluent interface adds overloads that correspond to the *legal* combinations of opcodes and parameters so you don't
risk emitting opcodes along with parameter in unsupported combinations.

The library aim to implement *all* the opcodes and various helper methods.
