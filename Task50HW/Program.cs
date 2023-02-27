// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 3 4
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
         for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i, j] = new Random().Next(1,10); // [1,9]
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

    Console.Write("Введите позицию элемента в массиве: ");
    int[] position = Console.ReadLine().Split().Select(p => int.Parse(p)).ToArray();

if (position[0] > size[0] || position[1] > size[1])
    Console.WriteLine("Позиции элемента в заданном массиве не существует.");
else
    Console.WriteLine($"Значение элемента в заданной вами позиции: {matrix[position[0]-1, position[1]-1]}");