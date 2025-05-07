// See https://aka.ms/new-console-template for more information


// The max value of byte is 255.
// int max = 500;
// if (max > byte.MaxValue)
// {
//     Console.WriteLine($"Warning: max ({max}) exceeds byte.MaxValue ({byte.MaxValue}).");
// }
// else
// {
//     for (byte i = 0; i < max; i++)
//     {
//         Console.WriteLine(i);
//     }
// }

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("fizzbuzz");
    else if (i % 5 == 0)
        Console.WriteLine("buzz");
    else if (i % 3 == 0)
        Console.WriteLine("fizz");
    else Console.WriteLine(i);
}

