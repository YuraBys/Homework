// Напишите программу которая на вход
// принимаетчисло, а на выход дает его квадрат
// (Число умноженное само на себя)
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square} ");

