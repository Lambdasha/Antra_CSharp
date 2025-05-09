// See https://aka.ms/new-console-template for more information

using Color_Ball;

// create some colors
var red   = new Color(255, 0,   0);
var green = new Color(0,   255, 0, 128);

// create balls
var b1 = new Ball(5.0, red);
var b2 = new Ball(green);

b1.Throw();
b1.Throw();
b1.Pop();
b1.Throw();
b2.Throw();

Console.WriteLine($"b1 was thrown {b1.GetThrowCount()} times (size now {b1.GetSize()})");
Console.WriteLine(
    $"b2 was thrown {b2.GetThrowCount()} times (size {b2.GetSize()}, color {b2.GetColor()})"
);
