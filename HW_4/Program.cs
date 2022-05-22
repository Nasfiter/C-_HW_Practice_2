// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// Примеры:
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число соответствующее дню неделит: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void Checking  (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else { 
    Console.WriteLine("это точно не выходной!");
  }
}

Checking(dayNumber);