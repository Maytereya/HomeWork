/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.Write("Введите координату Х числа A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y числа А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z числа А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х числа B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y числа B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z числа B: ");
int zb = Convert.ToInt32(Console.ReadLine());


double L = Math.Round(Math.Sqrt(Math.Pow(xa-xb, 2) + Math.Pow(ya-yb, 2)+ Math.Pow(za-zb, 2)), 2);

Console.WriteLine($"Расстояние между точками в 2D составляет: {L}");