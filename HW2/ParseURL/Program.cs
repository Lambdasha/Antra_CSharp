// See https://aka.ms/new-console-template for more information

string url = Console.ReadLine();

string protocol = "";
string server   = "";
string resource = "";

int protoSep = url.IndexOf("://");

string rest = url;
if (protoSep >= 0)
{
    protocol = url.Substring(0, protoSep);
    rest = url.Substring(protoSep + 3);
}

int resSep = rest.IndexOf('/');
if (resSep >= 0)
{
    server = rest.Substring(0, resSep);
    resource = rest.Substring(resSep + 1);
}
else
{
    server = rest;
}

Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource}\"");
