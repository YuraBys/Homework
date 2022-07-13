// Задача 44. Не используя рекуссию, выведите первые N чисел Фибоначчи. Первые два числа 0 и 1
// Если N = 5 --> 0 1 1 2 3;
// Если N = 3 --> 0 1 1;
// Если N = 7 --> 0 1 1 2 3 5 8;


Console.Write("Укажите количество чисел Фибоначчи для вывода: ");
int n = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
int counter = 0;

Console.Write($"{first} ");
Console.Write(second);
for(int i = 2; i < n; i++)
{
    counter = first + second;
    Console.Write($"{counter} ");
    first = second;
    second = counter;
}