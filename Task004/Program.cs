//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1 целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 целое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 целое число ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Максимальное число = {max} ");
