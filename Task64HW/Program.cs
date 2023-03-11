string rec(int n)
 {
 if (n == 1)
     return "1";
              return $"{n}, " + rec(n - 1);

 }

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));