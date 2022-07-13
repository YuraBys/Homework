// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = {3.5, 7.1, 22.9, 2.3, 78.5};
void PrintArray(double[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
            if (i == 0) Console.Write("[");
            if (i <  arr.Length - 1) Console.Write(arr[i] + "; ");
            else Console.Write(arr[i] + "]");
    }
    
}

double Search(double[] array)
{
  double maxPos = array[0];
  double minPos = array[0];
  for (int i = 0; i < array.Length; i++)
  {
  if(maxPos < array[i]) 
  {
    maxPos = array[i];
  }
  else
  {
minPos = array[i];
  }
  }
  double result = maxPos - minPos;
  return result;
}

PrintArray(arr);
double[] res = Search(arr);
Console.WriteLine(res);