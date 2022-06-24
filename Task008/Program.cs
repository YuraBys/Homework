//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите 1 целое число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 1)
{
    for (int index = 2; index <= n; index = index + 2)
     Console.Write($"{index} "); 
}
else 
{for (int index = n; index <= 1; index = index + 2)
     Console.Write($"{index} "); 
}