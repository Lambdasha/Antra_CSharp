// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

String str = Console.ReadLine();
string[] tokens = Regex.Split(str, "[^A-Za-z]+");

var palindromes = new List<string>();
foreach (var token in tokens)
{
    string rev = new string(token.Reverse().ToArray());
    if (token == rev && !palindromes.Contains(token))
        palindromes.Add(token);
}

Console.WriteLine(string.Join(", ", palindromes.OrderBy(s => s)));



