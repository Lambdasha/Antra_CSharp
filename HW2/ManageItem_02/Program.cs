// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter command (+ item, - item, or -- to clear): ");
string str = Console.ReadLine();
var items = new List<string>();
while (true)
{

    string item = str[2..];
    if (str.StartsWith("+ "))
    {   
        if (!items.Contains(item)) items.Add(item);
        else Console.WriteLine("Item already exists.");
    }
    else if (str.StartsWith("- "))
    {
        if (items.Contains(item)) items.Remove(item);
        else Console.WriteLine("Item not found.");
    }
    else if (str == "--") items.Clear();
    Console.WriteLine("Current list:");
    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine(items[i]);
    }
    Console.WriteLine("Enter command (+ item, - item, or -- to clear): ");
    str = Console.ReadLine();
}


