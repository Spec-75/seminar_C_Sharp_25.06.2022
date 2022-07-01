// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next();
//int number = 45;

Console.WriteLine($"Рандомное число: {number}");
if(number > 99)
{
    Console.WriteLine($"Третья цифра в этом числе: {number.ToString()[2]}");
}
else
{
    Console.WriteLine("В этом числе нет третьей цифры");
}
