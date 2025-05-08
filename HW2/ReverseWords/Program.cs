// See https://aka.ms/new-console-template for more information

using System.Text;

String str = Console.ReadLine();
var seps = new HashSet<char> {'.', ',', ':', ';', '=', '(', ')', '&', 
    '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};
StringBuilder sbWord = new StringBuilder();
StringBuilder sbSeparator = new StringBuilder();
var tokensWord = new List<string>();
var tokensSeparator = new List<string>();
bool a = true;
bool b = true;
if (seps.Contains(str[0]))
{
    a = false;
    Console.WriteLine("The input should start with a word!");
}

if (!seps.Contains(str[str.Length - 1]))
{
    b = false;
    Console.WriteLine("The input should end with a separator!");
}

if (a && b)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (seps.Contains(str[i]))
        {
            if (sbWord.Length > 0) tokensWord.Add(sbWord.ToString());
            sbWord.Clear();
            sbSeparator.Append(str[i]);
        }
        else
        {
            if (sbSeparator.Length > 0) tokensSeparator.Add(sbSeparator.ToString());
            sbSeparator.Clear();
            sbWord.Append(str[i]);
        }
    }

// The last separator being mistakenly ignored in the for loop.
    tokensSeparator.Add(sbSeparator.ToString());

    tokensWord.Reverse();

    // Console.WriteLine(string.Join(",", tokensWord));
    // Console.WriteLine(string.Join(",", tokensSeparator));

    int len =  tokensWord.Count+ tokensSeparator.Count;
    for (int j = 0; j < len; j += 2)
    {
        int k = j / 2;
        Console.Write(tokensWord[k]);
        Console.Write(tokensSeparator[k]);
    
    }
}

