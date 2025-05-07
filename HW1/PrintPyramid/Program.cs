// See https://aka.ms/new-console-template for more information

if (!int.TryParse(Console.ReadLine(), out int a))
{
    Console.WriteLine("Invalid integer.");
    return;
}

for (int i = 1; i <= a; i++)
{
    int stars = i * 2 - 1;
    int spaces = (a * 2 - 1 - stars) / 2;
    for (int j = 0; j < spaces; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < stars; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
