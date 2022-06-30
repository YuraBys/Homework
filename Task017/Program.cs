// 17. Напишите программу которая на вход принимает координаты точки (X & Y),
// причем X != 0, Y != 0 и выдает
//номер четверти плоскости, в которой лежит эта точка

Console.WriteLine("Координаты точки X  и Y ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}
string result = Quarter (x, y);
Console.WriteLine(result);

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные координаты");

// string Quarter (int xc, int yc)
// {
//     string result = "";
//     if (x > 0 && y > 0) result = "Первая четверть";
//     else if (x < 0 && y > 0) result = "Вторая четверть";
//     else if (x < 0 && y < 0) result = "Третья четверть";
//     else if (x > 0 && y < 0) result = "Четвертая четверть";
//     else result = "Введены некорректные координаты";
//     return result;
// }

