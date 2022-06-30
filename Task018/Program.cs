// Задача 18.
// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат этой четверти (x и y)/

Console.WriteLine("Введите номер четверти ->> ");
int quater = Convert.ToInt32(Console.ReadLine());

string Koord (int q)
{
    if (q == 1) return "Координаты X > 0 и Y > 0";
    if (q == 2) return "Координаты X < 0 и Y > 0";
    if (q == 3) return "Координаты X < 0 и Y < 0";
    if (q == 4) return "Координаты X > 0 и Y < 0";
    return "Введена некорректная четверть";
}
string result = Koord (quater);
Console.WriteLine(result);


// string Koord (int q)
// {
//     switch (q)
//     {
//         case 1:
//         return "Координаты X > 0 и Y > 0";
//         break;

//         case 2:
//         return "Координаты X < 0 и Y > 0";
//         break;

//         case 3:
//         return "Координаты X < 0 и Y < 0";
//         break;

//         case 4:
//         return "Координаты X > 0 и Y < 0";
//         break;

//         default:
//         return "Введена некорректная четверть";
//         break;

//     }
    
    
// }