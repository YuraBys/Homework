 // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers= new int[m];

void MassiveNumbers(int m)
{
    for(int i = 0; i < m; i++)
    {
       Console.Write($"Введите {i + 1} число: "); 
       numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Counter(int[] numbers)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
       if(numbers[i] > 0) count += 1;
    }
    return count;

}

MassiveNumbers(m);
int result = Counter(numbers);
Console.WriteLine($"Количество чисел больше нуля --> {result}"); 