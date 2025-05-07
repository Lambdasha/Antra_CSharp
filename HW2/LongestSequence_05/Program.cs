// See https://aka.ms/new-console-template for more information

string str = Console.ReadLine();
string[] strSplit = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] intSplit = new int[strSplit.Length];
for (int i = 0; i < strSplit.Length; i++)
{
    intSplit[i] = int.Parse(strSplit[i]);
}
int max = -1;
int start = 0;
int end = 0;
int posStart = 0;

for (int i = 0; i < intSplit.Length; i++)
{
    if (intSplit[i] == intSplit[posStart])
    {
        if (i - posStart > max)
        {
            max = i - posStart;
            start = posStart;
            end = i;
        }
    }
    else
    {
        posStart = i;
    }
}

for (int j = start; j <= end; j++)
{
    Console.Write(intSplit[j] + " ");
}
Console.WriteLine();
