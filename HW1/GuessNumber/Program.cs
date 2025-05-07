// See https://aka.ms/new-console-template for more information

int guessedNumber = int.Parse(Console.ReadLine());

var rng = new Random();
int a = rng.Next(1, 3);
if (guessedNumber < 1 || guessedNumber > 3)
{
    Console.WriteLine("Invalid guesses: outside of the range of numbers.");
}
else if (guessedNumber == a)
{
    Console.WriteLine("Correct guess!");
}
else if (guessedNumber > a)
{
    Console.WriteLine("Too high!");
}
else if (guessedNumber < a)
{
    Console.WriteLine("Too low!");
}
