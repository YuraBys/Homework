// Задача42. Напишите программу, котрая будет преобразовывать десятичое число в двоичное
// 45 --> 101101
// 3 --> 11
// 2 --> 10

// int a;
// int[] result;
// string answer;
// Console.Write("Введите число: ");
// a = Convert.ToInt32(Console.ReadLine());
// result = ConvertToBool(a);
// answer = MakeViewStrinMassive(result);
// Console.WriteLine(answer);

// int[] ConvertToBool(int a)
// {
//     int b = a % 256;
//     int[] boolean = new int[8];
//     int razr = 128;

//     for (int i = 0; i < boolean.Length; i++)
//     {
//         if (b >= razr)
//         {
//             b = b - razr;
//             boolean[i] = 1;
//         }
//         else
//         {
//             boolean[i] = 0;
//         }
//         razr /= 2;
//     }
//     return boolean;
// }

// string MakeViewStrinMassive(int[] massive)
// {
//     string viewString = "[";
//     int j = 1;
//     for (int i = 0; i < massive.Length; i++; j++)
//     {
//             viewString += Convert.ToString(massive[i]);
//         if (j != massive.Length) 
//         {viewString += ", ";}
//     }
//     viewString += "]";
//     return viewString;
// }

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите основание системы исчисления: ");
// int baseNum = int.Parse(Console.ReadLine());

// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
//     result = result + number % baseNum * d10;
//     number = number / baseNum;
//     d10 = d10 * 10;
// }
// Console.WriteLine(result);


int a = 13;
void ToBin(int n)
{
    if(n == 0) return;
    ToBin(n / 2);
    Console.Write(n % 2);
}
ToBin(a);