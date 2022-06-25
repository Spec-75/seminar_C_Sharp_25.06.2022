//int x = 4;
//Console.Write("Введите первое целое число: ");
//int squareNumber = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе целое число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (squareNumber == number*number) 
//{
  //  Console.WriteLine("Первое число является квадратом второго");
//}

//else 
//{
  //  Console.WriteLine("Первое число НЕ является квадратом второго");
//}

//Console.Write("Квадрат данного числа равен: ");
//Console.Write(Result);
/*Console.WriteLine("Ведите день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
//Больше или равно
if (dayNumber >=1 && dayNumber <= 7)// && - and 
//обязательно выполнять условие первое и второе 
{
     if (dayNumber == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (dayNumber == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (dayNumber == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (dayNumber == 3)
    {
        Console.WriteLine("Среда");
    }
    if (dayNumber == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (dayNumber == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (dayNumber == 6)
    {
        Console.WriteLine("Суббота");
    }
    if (dayNumber == 7)
    {
        Console.WriteLine("Воскресенье");
    }
else
{
    Console.WriteLine("Это не день недели");
}
}
*/
Console.Write("Ведите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1); //4*(-1) = -4 до N
while (negativeN<= N)
{
    Console.WriteLine(negativeN);
    negativeN++;
}
