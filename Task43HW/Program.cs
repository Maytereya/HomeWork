Console.Clear();
Console.Write("Введите коэффициент первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2-b1) / (k1-k2);
double y = k1 * x + b1;

Console.WriteLine($"({Math.Round(x, 2)}, {Math.Round(y, 2)})");