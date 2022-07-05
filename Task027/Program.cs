// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число для подсчета суммы цифр в нем: ");
int numA = Convert.ToInt32(Console.ReadLine());

int Summ (int number)
{   int sum = 0;
    while (number > 0)
    {
        int num = number % 10;
        sum = sum + num;
        number = number / 10;

    }
    return sum;
}

int result = Summ(numA);
Console.WriteLine($"{numA} ->  {result}");
