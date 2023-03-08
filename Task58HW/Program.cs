// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void InputMatrix(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
         for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i, j] = new Random().Next(1,10); // [1,9]
        }
    }

void MatrixProduct(int[,] matrix1, int[,] matrix2)
    {
    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
         for (int j = 0; j < matrix1.GetLength(1); j++)
            matrix1[i, j] *= matrix2 [i, j];
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
    Console.Write("Введите размер массивов: ");
    int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    int[,] matrix1 = new int [size[0], size[1]];
    int[,] matrix2 = new int [size[0], size[1]];

InputMatrix(matrix1);
InputMatrix(matrix2);
Console.WriteLine("________Матрица 1________");
PrintMatrix(matrix1);
Console.WriteLine("________Матрица 2________");
PrintMatrix(matrix2);
MatrixProduct(matrix1, matrix2);
Console.WriteLine("___Результат умножения___");
PrintMatrix(matrix1);
