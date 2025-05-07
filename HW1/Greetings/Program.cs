// See https://aka.ms/new-console-template for more information

DateTime now = DateTime.Now;
int hour = now.Hour;
if (hour >= 5 && hour < 12)
    Console.WriteLine("Good Morning");
if (hour >= 12 && hour < 18)
    Console.WriteLine("Good Afternoon");
if (hour >= 18 && hour < 21)
    Console.WriteLine("Good Evening");
if (hour < 5 || hour >= 21)
    Console.WriteLine("Good Night");