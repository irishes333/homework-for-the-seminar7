// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array = GenerateNewTwoDimensionalArray(); 
            string index = ReadNumberFromConsole(array.GetLength(0), array.GetLength(1));
            PrintTwoDimensionalArray(array); 
            SearchAndWriteNumberFromArray(index, array); 



        static int[,] GenerateNewTwoDimensionalArray() 
        {
            int[,] array = new int[3, 4]; 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10); 
                }
            }
            return array;
        }
        static string ReadNumberFromConsole(int index0=3, int index1=4) 
        {
            while (true)
            {
                             Console.WriteLine("В заданном массиве " + index0 + " строки " +
                "и " + index1 + " столбца.");
                Console.Write("Введите число от 1, где первая цифра будет номером строки, " +
                "а вторая номером столбца: ");
                string? inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out int number))
                {
                    return inputNumber;
                }
                Console.WriteLine("Вы ввели не число!");
            }
        }

        static void SearchAndWriteNumberFromArray(string index, int[,] array) 
        {
            int[] digits = index.Select(c => (int)char.GetNumericValue(c)).ToArray(); 

            try 
            {
                   Console.WriteLine(index + " -> " + array[(digits[0]) - 1, (digits[1]) - 1]);
            }
            catch (IndexOutOfRangeException) 
            {
                Console.WriteLine(index + " -> такого числа в массиве нет (индекс " + index + " не существует)"); 
            }
        }

         static void PrintTwoDimensionalArray(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
