// Работа с массивом

Console.Clear();
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double[n];
int begin = 10, end = 20;
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round (new Random().NextDouble()*(end - begin) + begin ,2);

Console.WriteLine($"[{string.Join(", ", array)}]");