Console.Clear();
int [] array = new int [7];
for (int i  = 0; i < array.Length; i++)
array[i] = new Random().Next(100 , 1000); // [100, 999]
Console.WriteLine($"Начальный массив: [{string.Join(",", array)}]");
int result = 0;

foreach (int item in array)
{
    if (item%2 == 0)
result++;
   
}

Console.WriteLine($"Количество четных чисел в массиве: {result}");