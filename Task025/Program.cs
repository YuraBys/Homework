// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("ВВедите 2 числа: ");
Console.Write("A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Stepen(int number1, int number2 )
{   int count = number1;
    for (int i = 1; i < number2; i++) 
    {
        count = count * number1;
    }
    return count;
}
int result = Stepen(numA, numB);
Console.WriteLine($" Число {numA} в степени {numB} -> {result}");