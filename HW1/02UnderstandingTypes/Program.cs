﻿// See https://aka.ms/new-console-template for more information

using System.Numerics;

Console.WriteLine($"{"Type", -10} {"Size",-10} {"MinValue", -40} {"MaxValue", -40}");
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "short", sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "int", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "long", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "float", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "double", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine("{0, -10} {1, -10} {2, -40} {3,-40}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);


