﻿namespace IntegralTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Data Types stored in the Stack");
        System.Console.WriteLine("");
        Console.WriteLine("Signed inegral types: ");
        System.Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
        System.Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
        System.Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
        System.Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

        Console.WriteLine("");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        Console.WriteLine("");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        System.Console.WriteLine("");
        System.Console.WriteLine("Data Types stored in the Heap");
        System.Console.WriteLine("");

        int[] data = new int[3];
    }
}
