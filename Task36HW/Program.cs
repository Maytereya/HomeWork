Console.Clear();
int [] array = new int [7];
for (int i  = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10 , 11); // [-10, 10]
Console.WriteLine($"Начальный массив: [{string.Join(",", array)}]");
int result = 0;

for (int k = 1; k <array.Length; k+=2)
    result += array[k];

Console.WriteLine($"Сумма элементов на нечетных позициях в массиве: {result}");