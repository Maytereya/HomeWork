// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01(0,0) 02(0,1) 03(0,2) 04(0,3)
// 12(1,0) 13(1,1) 14(1,2) 05(1,3)
// 11(2,0) 16(2,1) 15(2,2) 06(2,3)
// 10(3,0) 09(3,1) 08(3,2) 07(3,3)

//Заполним массив, количество строк m, а столбцов - n.
        int m = 4;
        int n = 4;
 
//s задает числа внутри массива начиная с 1.
        int s = 1;
 
        int[,] matrix = new int[m, n];
 
//Заполняем периметр массива.
        for (int y = 0; y < n; y++) 
        {
            matrix[0, y] = s;
            s++;
        }
        for (int x = 1; x < m; x++) 
        {
            matrix[x, n - 1] = s;
            s++;
        }
        for (int y = n - 2; y >= 0; y--) {
            matrix[m - 1, y] = s;
            s++;
        }
        for (int x = m - 2; x > 0; x--) {
            matrix[x, 0] = s;
            s++;
        }

    
        int c = 1;
        int d = 1;
 
        while (s < m * n) 
        {
//Движемся вправо
            while (matrix[c, d + 1] == 0) 
            {
                matrix[c, d] = s;
                s++;
                d++;
            }
 
//Движемся вниз
            while (matrix[c + 1, d] == 0) 
            {
                matrix[c, d] = s;
                s++;
                c++;
            }
 
//Движемся влево
            while (matrix[c, d - 1] == 0) 
            {
                matrix[c, d] = s;
                s++;
                d--;
            }
 
//Движемся вверх
            while (matrix[c - 1, d] == 0) 
            {
                matrix[c, d] = s;
                s++;
                c--;
            }
        }

//Убрать ноль в центре

        for (int x = 0; x < m; x++) 
        {
            for (int y = 0; y < n; y++) 
            {
                if (matrix[x, y] == 0) 
                    matrix[x, y] = s;
                
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
PrintMatrix(matrix);