Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), i = 1, f = 1;
while (i <= n)
{
    f = f*i;
    i++;
}

Console.WriteLine($"n!{n}: {f}");

//Версия преподавателя
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= n; i++)
    result *= i;
Console.WriteLine($"n!{n}: {result}");  
