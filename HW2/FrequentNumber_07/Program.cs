// See https://aka.ms/new-console-template for more information

string str = Console.ReadLine();
string[] strSplit = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] intSplit = new int[strSplit.Length];
var list = new List<int>();

for (int i = 0; i < strSplit.Length; i++)
{
    intSplit[i] = int.Parse(strSplit[i]);
}
var counts = new Dictionary<int, int>();
int leftmost = 0;
int max = 0;
foreach (var item in intSplit)
{
    if (!counts.ContainsKey(item))
    {
        counts[item] = 0;
    }
    counts[item]++;
    if (counts[item] > max)
    {
        max = counts[item];
        leftmost = item;
    }
}

foreach (var item in intSplit)
{
    if (counts[item] == max && !list.Contains(item))
    {
        list.Add(item);
    }
}

if (list.Count == 1)
{
    Console.WriteLine($"The number {list[0]} is the most frequent (occurs {max} times)");
}
else
{
    string numbersList = string.Join(", ", list);
    Console.WriteLine($"The numbers {numbersList} have the same maximal frequency (each occurs {max} times). The leftmost of them is {leftmost}.");
}