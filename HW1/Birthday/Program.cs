// See https://aka.ms/new-console-template for more information

DateTime birthDate = new DateTime(1999, 12, 20);
DateTime today = DateTime.Today;

int days = (int)(today - birthDate).TotalDays;
int daysToNextAnniversary = 10000 - (days % 10000);
DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
Console.WriteLine($"Born on: {birthDate:yyyy-MM-dd}");
Console.WriteLine($"Today is: {today:yyyy-MM-dd}");
Console.WriteLine($"You are {days} days old.");
Console.WriteLine($"Your next 10,000 day anniversary falls on {nextAnniversary:yyyy-MM-dd}.");
