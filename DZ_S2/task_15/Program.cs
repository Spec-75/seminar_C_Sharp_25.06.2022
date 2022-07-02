// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели от 1 до 7");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay >0 && weekDay < 8)
{
    if (weekDay == 1)
    {
        Console.WriteLine("Это не выходной!");
    }
    if (weekDay == 2)
    {
        Console.WriteLine("Это не выходной!");
    }
    if (weekDay == 2)
    {
        Console.WriteLine("Это не выходной!");
    }
    if (weekDay == 3)
    {
        Console.WriteLine("Это не выходной!");
    }
    if (weekDay == 4)
    {
        Console.WriteLine("Это не выходной!");
    }
    if (weekDay == 5)
    {
        Console.WriteLine("Это не выходной!");
    }
    if (weekDay == 6)
    {
        Console.WriteLine("Это выходной!");
    }
    if (weekDay == 7)
    {
        Console.WriteLine("Это выходной!");
    }
}
else
{
    Console.WriteLine("Это не день недели");
}