// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//int number = new Random().Next();
//Console.WriteLine($"Число = {number}");

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
var NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
    Console.Write("третья цифра = ");
    Console.Write(NumberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
