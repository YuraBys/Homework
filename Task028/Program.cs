// адача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число для : ");
int num = Convert.ToInt32(Console.ReadLine());
int x = 1;
int Count(int number)
{
 for (int i = 1; i <= number; i++)
 x = i * x;
 return x;

}
int result = Count(num);
Console.WriteLine(result);