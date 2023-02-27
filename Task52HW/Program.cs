﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
         for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i, j] = new Random().Next(1,10); // [1,9]
        }
    }

void MedialSumMatrix(int[,] matrix)
    {
       int j = 0;
while (j < matrix.GetLength(1))
{
   int i = 0;
    double msum = 0;
    while (i < matrix.GetLength(0))

        {
         msum += matrix[i, j];
         i++;
        }

    msum /= matrix.GetLength(0);
    Console.WriteLine($"Среднее арифметическое {j+1}-го столбца: {Math.Round(msum, 2)}");
    j++;
}
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
    int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int [size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
MedialSumMatrix(matrix);