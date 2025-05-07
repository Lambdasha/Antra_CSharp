// See https://aka.ms/new-console-template for more information

int[] arr = [0,1,2,3,4,5,6,7,8,9];

int[] arrCopy = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arrCopy[i] = arr[i];
}

Console.Write("Original arrary: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.Write("Copied arrary: ");
for (int i = 0; i < arrCopy.Length; i++)
{   
    Console.Write($"{arrCopy[i]} ");
}