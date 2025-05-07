// See https://aka.ms/new-console-template for more information

if (!long.TryParse(Console.ReadLine(), out long century))
{
    Console.WriteLine("Invalid integer.");
    return;
}

long year = century * 100;
long leapYears = year / 4 - year / 100 + year / 400;
long day = year * 365 + leapYears * 1;
long hour = day * 24;
long minute = hour * 60;
long second = minute * 60;

Console.WriteLine($"{century} centuries = {year} years = {day} days = {hour} hours = {minute} minutes = {second} seconds = {second}000 milliseconds = {second}000000 microseconds = {second}000000000 nanoseconds");