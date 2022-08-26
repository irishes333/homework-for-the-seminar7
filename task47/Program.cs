// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Задайте двумерный массив размером mхn."); 
        Console.WriteLine("Введите m:"); 
        int rowLength = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Введите n:"); 
        int columnLength = Convert.ToInt32(Console.ReadLine()); 

        double[,] twoDimensionalArray = new double[rowLength, columnLength]; 
        RandomFillTwoDimensionalArray(twoDimensionalArray); 
        PrintArray(twoDimensionalArray); 

        static void RandomFillTwoDimensionalArray(double[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * new Random().Next(-10, 10); 
                }
            }
        }

     static void PrintArray(double[,] incomingArray)
        {
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
        Console.Write($"{Math.Round(incomingArray[i, j], 2)} ");
        }
        Console.WriteLine();
        }
        }
