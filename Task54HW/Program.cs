// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InputMatrix(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
         for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i, j] = new Random().Next(0,11);
        }
    }

void MatrixDescend(int[,] matrix)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
        int[]array = new int[matrix.GetLength(0)];
        int i;
        for (i = 0; i < array.Length; i++)
        array[i] = matrix[k, i];
        //Console.WriteLine($"[{string.Join(", ", array)}]");

    for (i = 0; i < array.Length; i++)
          {
                for (int j = 0; j < array.Length - 1 - i; j++)
                 {
                     if (array[j] < array[j + 1])
                        {
                          int temp = array[j];
                          array[j] = array[j + 1]; 
                          array[j + 1] = temp; 
                        }
                  }
            }
            
            for (i = 0; i < array.Length; i++)
            matrix[k, i] = array[i];
        //Console.WriteLine($"[{string.Join(", ", array)}]");
        
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
Console.WriteLine("Измененные строки массива: ");
MatrixDescend(matrix);
PrintMatrix(matrix);
