﻿//Задача 21.
// Напишите программу, которая на вход принимает координаты двух точек, и
// находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

Console.WriteLine("ВВедите координаты точки A: ");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите координаты точки B: ");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance (int xta, int yta, int xtb, int ytb)
{
    int cat1 = 0;
    int cat2 = 0;
    double result = 0.0;

    cat1 = Math.Abs(xta) - Math.Abs(xtb);
    cat2 = Math.Abs(yta) - Math.Abs(ytb);
    result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return Math.Round(result, 2);
}
double result = Distance(xa, ya, xb, yb);
Console.WriteLine($"Расстояние между точками А и В:  {result}");