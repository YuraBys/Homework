// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

void Check(int day)
{
if (day == 6 || day == 7) 
    Console.Write($"{day} -> Да");
    else if (day < 1 || day > 7)
    {
        Console.Write("Нет дня с таким номером");
    }
    else
    Console.Write($"{day} -> Нет");
}
Check(day);
