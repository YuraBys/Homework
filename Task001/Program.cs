// 1. Напишите программу, которая на вход принимает 2 числа     
// и проверяет, является ли первое квадратом второго.
// 25 5 да
// 2 10 нет
// 9 -3 да
// -3 9 нет

Console.Write("Введите 1 целое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 целое число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (second * second == first )
{
    Console.WriteLine($"Да число {first} является квадратом {second}");
}
else
{
    Console.WriteLine($"Нет число {first} не является квадратом {second}");
}