// Сумма чисел от 1 до n 

// Console.Clear();
// Console.Write("Введите число: ");
// string? n = Console.ReadLine();
// Console.WriteLine($"Длина последовательности: {n.Length}");

// Версия преподавателя
// не запускать оба кода одновременно!

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n = n/10;
    count++;
}

Console.WriteLine($"Длина последовательности: {count}");