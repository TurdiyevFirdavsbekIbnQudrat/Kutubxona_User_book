using Polymorphism;
using System.Diagnostics;

//Asus asus = new Asus();

//asus.TurnOn();
//asus.TurnOff();
//Console.WriteLine();

//Laptop laptop = asus;
//laptop.TurnOn();

//Console.WriteLine();
//Laptop laptop2 = new Laptop();
//laptop2.TurnOn();

//Asus asus = new Asus();
//asus.TurnOff();
//Laptop laptop = asus;
//laptop.TurnOff();

var input = int.Parse(Console.ReadLine());
var stopwatch = new Stopwatch();
stopwatch.Start();
var calc = new PrimeCalculator();
Console.WriteLine($"is prime {input} - {calc.IsPrime(input)} - elapsed - {stopwatch.ElapsedMilliseconds}");

stopwatch.Restart();
//var fasterCalc = new FasterPrimeCalculator();
PrimeCalculator fakeCalc = new FasterPrimeCalculator();
Console.WriteLine($"is prime {input} - {fakeCalc.IsPrime(input)} - {stopwatch.ElapsedMilliseconds}");

