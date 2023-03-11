int sum(int m, int n)
{
if (m == n)
    return m;
return sum(m, n-1) + n;

}

Console.Clear();
Console.Write("Введите число M (меньшее): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N (большее): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(m, n));
