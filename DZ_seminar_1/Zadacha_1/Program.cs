Console.WriteLine("Введите первое число ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2)
{
    Console.Write("Число ");
    Console.Write(Number1);
    Console.Write(" больше ");
    Console.Write(Number2);
}
else
{
    Console.Write("Число ");
    Console.Write(Number2);
    Console.Write(" больше ");
    Console.Write(Number1);
}