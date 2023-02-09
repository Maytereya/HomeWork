/*
А возводит в степень Б с помощью цикла
*/

Console.Clear();
Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine()), f = 1;

//3^5 = 3*3*3*3*3;
for (int i = 1; i <= b ; i++)
f *= a;
Console.WriteLine($"A в степени B: {f}");


