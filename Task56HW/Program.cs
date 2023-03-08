// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrix(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
         for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i, j] = new Random().Next(0,11);
        }
    }

void MatrixSearchSum(int[,] matrix)
    {
        int rowSumm;
        int [] array = new int[matrix.GetLength(1)];
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            rowSumm = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
             rowSumm += matrix[k, i];
             array[k] = rowSumm;
            }
        }
    int l, temp = array[0], flag = 0;
    for (l = 0; l < array.Length; l++)
       {
        if (array[l] < temp)
        temp = array[l];
       }
    for (l = 0; l< array.Length; l++)
    if (temp == array[l])
    {
         flag = l+1;
         break;
    }
   
        Console.WriteLine($"[{string.Join(", ", array)}]");
        Console.WriteLine($"Наименьшая сумма в строке: {temp}");
        Console.WriteLine($"Номер строки в массиве с наименьшей суммой элементов: {flag}");
        
    }
    
void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]} \t");
                Console.WriteLine();
            }
    }

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [size, size];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Cумма элементов строк в массиве: ");
MatrixSearchSum(matrix);