// Задайте массив из 12 элементов, заполненные случайными числами из промежутка [-9; 9].
// Найдите сумму отрицательных и положительных элементов массиваю
//   Например в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]. Сумма положительных чисел равна 29, отрицательных -20.

int[] CreateArrayRndInt(int size, int begin, int end)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);

    }
    return array;
}

int[] GetSumNegArrayPos(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];

        }
    }
    return new[] { sumNeg, sumPos };
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}


void PrintSumNegPosElem(int[] sum)
{
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных  чисел равна {sum[1]}");
    Console.WriteLine($"Сумма отрицательных  чисел равна {sum[0]}");
}

int[] resArray = CreateArrayRndInt(12, -9, 9);
PrintArray(resArray);
int[] sumNegPosElem = GetSumNegArrayPos(resArray);
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных  чисел равна {sumNegPosElem[1]}");
// Console.WriteLine($"Сумма отрицательных  чисел равна {sumNegPosElem[0]}");

