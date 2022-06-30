// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8
int number = new Random().Next(10,100);//[10,100] 100 не входит
Console.WriteLine($"Рандомное число: {number}");//интерполяция
int digitOne = number / 10; //45->4
int digitTwo = number % 10; //45->5
Console.WriteLine($"Первая цифра нашего числа: {digitOne}");
Console.WriteLine($"Вторая цифра нашего числа: {digitTwo}");
int max = Math.Max(digitOne,digitTwo);//max(1 числоб, 2число) Max печатает сам ое борльшое число из двух
Console.WriteLine("Самое большое число:" + max);
//int max = Math.Max(digitOne,digitTwo); // Max(1 число, 2 число), Max печатает самое большое число на экран среди 2
Console.WriteLine("Самое большое число: " + max);

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100,1000);//[10,100] 100 не входит
// Console.WriteLine($"Рандомное число: {number}");//интерполяция
// int digitOne = number / 100; //45->4
// int digitTree = number % 10; //45->5
// Console.WriteLine(digitOne);
// Console.WriteLine(digitTree);
// Console.WriteLine($"{digitOne}" + $"{digitTree}");


//способ с функцией
// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

// int SearchNumber(int number) 
// {
//     int first = number / 100; // 456 -> 4
//     int third = number % 10; // 456 -> 6
//     return first * 10 + third;  // 4,6 -> 4*10 + 6 = 46
// }

// Console.WriteLine(SearchNumber(number));


// 12.Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// int numberFirst = Convert.ToInt32(Console.ReadLine());//Console.Read();//read - int32
// int numberSecond = Convert.ToInt32(Console.ReadLine());//Console.Read();
// if (numberFirst / numberSecond == 0)
// {
//     Console.Write("Числа кратны друг другу");
// }
// else
// {
//     Console.Write($"Остаток от деления {numberFirst % numberSecond}");
// }

// 14.Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// int number = Convert.ToInt32(Console.ReadLine());
// bool paritycheck (int number)
// {
//     return(number % 7 == 0 && number % 23 == 0);//True, false
// }
// Console.WriteLine(paritycheck(number));