Console.Clear();
int [] array = new int [7];
for (int i  = 0; i < array.Length; i++)
array[i] = new Random().Next(10 , 51);
Console.WriteLine($"Начальный массив: [{string.Join(",", array)}]");
int min = 50, max = 0;

foreach (int item in array)
{
    if (item > max)
    max = item;

else if (item < min)
    min = item;

}
//Console.WriteLine(max);
//Console.WriteLine(min);
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max-min}");