// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();

// Convert the string to char array, reverse it, then convert it to string again
char[] chars = input.ToCharArray();
Array.Reverse(chars);
string reversed = new string(chars);
Console.WriteLine(reversed);

//Print the letters of the string in back direction (from the last to the first) in a for-loop
for (int i = input.Length - 1; i >= 0; i--)
{
    Console.Write(input[i]);
}
Console.WriteLine();
