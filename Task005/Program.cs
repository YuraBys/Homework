// Программа которая на вход принимает 1 число N,
// а на выходе показывает все целые числа
// в промежутке от (-N,N)
// 4 -> -4,-3,...3,4
// 2 -> -2,=1,0,1,2

Console.WriteLine("Введите 1 целое число ");
int n = Convert.ToInt32(Console.ReadLine());
for (int index = -n; index <= n; index++)
{
    Console.Write($"{index}, ");  
}


