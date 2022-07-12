// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов которые лежат в отрезке [10, 99]

int SearchElem (int[] array, int begin, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= begin && array[i] <= end) count++;
    }
    return count;
}

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


void PrintArray(int[] array)
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}


void PrintRes(int res)
{
    Console.Write ($"Количество элементов массива в диапазоне [10, 99]:  {res}");

}
Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine ()); 
Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine ()); 
Console.Write ("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine ()); 

int[] genaarr = CreateArrayRndInt(insize, min, max);
int result = SearchElem(genaarr, 10, 99);

PrintArray(genaarr);
PrintRes(result); 
