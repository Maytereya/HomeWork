// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int i = 0, m = 0, n = 0, k = 0;
Console.Write("введите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
while (i < n)
{
Console.Write("введите число: ");
k = Convert.ToInt32(Console.ReadLine());
if (k > 0)
{
m++;
}
i++;
}
Console.WriteLine($"Чисел больше нуля: {m}");