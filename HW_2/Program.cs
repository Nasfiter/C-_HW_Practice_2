// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
//этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int  rundomNumber = new Random().Next(100, 1000); // rundom 3-x number
Console.WriteLine($"трехзначный номер = {rundomNumber}"); // print the number
int lastDigit = rundomNumber % 10; // found last digit 
int fitrstDigit = rundomNumber / 100; // found first digit 
// Console.WriteLine($"Крайние числа =  {firstDigit} {lastDigit}" );
Console.Write("Тоже самое число за искоючением чреднего номера = "); // conclusion 
Console.Write(fitrstDigit);
Console.Write(lastDigit);

