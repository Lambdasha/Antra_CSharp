// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 4; i++)
{
    int a = i;
    for (int j = 0; j < 24; j = j + a)
    {
        Console.Write(j);
        Console.Write(",");
    }
    Console.Write(24);
    Console.WriteLine();
}