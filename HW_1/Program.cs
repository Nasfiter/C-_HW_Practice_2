// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000); // rendome number from 100 till 999 
Console.Write("number = "); // print number =
Console.WriteLine(number); // displade rundom number xxx
int SecondNumber = number % 100; // took over first digit
//Console.WriteLine($"Result = {SecondNumber}"); // test 
int SecondDigit = SecondNumber / 10; // took over last digit by / 
Console.WriteLine($"Second number = {SecondDigit}");


