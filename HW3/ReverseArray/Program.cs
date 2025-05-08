// See https://aka.ms/new-console-template for more information

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }
    static int[] GenerateNumbers(int length = 10)
    {
        var result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = i + 1;
        }
        return result;
    }
    static void Reverse(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = array[i];
            array[i] = array[n - i - 1];
            array[n - i - 1] = temp;
        }
    }
    static void PrintNumbers(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
