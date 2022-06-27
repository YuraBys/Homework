// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое 3-х значное число ");
int x = Convert.ToInt32(Console.ReadLine());

 int ShowMid (int x)
 {
     int firstDig = x % 100 / 10;
     
     return firstDig;
 }
 int result = ShowMid(x);
Console.WriteLine($"Вторая цифра числа {x} (через метод): {result}");