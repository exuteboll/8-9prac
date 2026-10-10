using System;

namespace Prak8_9
{
    class Program
    {....
        // Процедура для проверки, содержатся ли в переданном столбце матрицы только положительные элементы
        static bool IsColumnPositive(double[,] matrix, int colIndex, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, colIndex] <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        ........
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Практическая работа №8-9: Разработка и интеграция модулей проекта ===");
            Console.WriteLine("Вариант 1: Поиск столбцов с только положительными элементами в двух двумерных массивах.\n");

            // Инициализация массива 1 (3x3)
            int rows1 = 3, cols1 = 3;
            double[,] matrix1 = {
                { 1.5, 2.0, -1.0 },
                { 3.2, 4.1, 5.0 },
                { 0.5, 1.0, 2.5 }
            };

            // Инициализация массива 2 (3x4)
            int rows2 = 3, cols2 = 4;
            double[,] matrix2 = {
                { 2.1, 3.4, 1.2, 5.6 },
                { 4.0, 1.1, 3.3, 0.1 },
                { 5.5, 6.2, 2.2, 4.4 }
            };

            ProcessMatrix("Массив 1", matrix1, rows1, cols1);
            ProcessMatrix("Массив 2", matrix2, rows2, cols2);

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void ProcessMatrix(string matrixName, double[,] matrix, int rows, int cols)
        {
            Console.WriteLine($"--- {matrixName} ({rows}x{cols}) ---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],6:F1} ");
                }
                Console.WriteLine();
            }

            bool found = false;
            Console.Write("Столбцы, содержащие только положительные элементы: ");
            for (int j = 0; j < cols; j++)
            {
                if (IsColumnPositive(matrix, j, rows))
                {
                    Console.Write($"{j + 1} ");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Нет таких столбцов.");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
