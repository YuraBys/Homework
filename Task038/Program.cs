// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int begin, int end)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] =Math.Round(new Random().Next(begin, end + 1) + new Random().NextDouble(), 1);

    }
   return array;
}

void PrintArray(double[] array2)
{
    Console.WriteLine($"Сгенерированный массив из {array2.Length} элементов");
    for (int i = 0; i < array2.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array2.Length - 1) Console.Write(array2[i] + "; ");
        else Console.WriteLine(array2[i] + "]");
    }
}

double DiffMinMaxElem(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxElem < array[i]) maxElem = array[i];
        if(minElem > array[i]) minElem = array[i];
    }
    double result = maxElem - minElem;
    return result;
}



Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine ()); 
Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine ()); 
Console.Write ("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine ()); 

double[] genaarr = CreateArrayRndInt(insize, min, max);
// double[] genaarr = {3.5, 7.1, 22.9, 2.3, 78.5};
PrintArray(genaarr);
double answer = Math.Round(DiffMinMaxElem(genaarr), 1);
Console.WriteLine($"{answer}");