// See https://aka.ms/new-console-template for more information

string str = Console.ReadLine();
string[] strSplit = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] intSplit = new int[strSplit.Length];
for (int i = 0; i < strSplit.Length; i++)
{
    intSplit[i] = int.Parse(strSplit[i]);
}

int times = Convert.ToInt32(Console.ReadLine());
// foreach (var part in intSplit) Console.Write($"{part},");
// Console.WriteLine(times);
int[] sum = new int[strSplit.Length];
for (int j = 1; j <= times; j++)
{
    for (int p = 0; p < intSplit.Length; p++)
    {
        int pos = (j + p) % strSplit.Length;
        sum[pos] += intSplit[p];
        
    }
}

Console.WriteLine(string.Join(' ', sum));