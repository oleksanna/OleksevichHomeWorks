// 1. Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он
// принимает на вход двумерный массив целых чисел matrix и выводит его элементы в
// виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по
// убыванию. Он принимает на вход двумерный массив целых чисел matrix и
// сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по
// убыванию.

// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

// На выходе:
// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Матрица с упорядоченными по убыванию строками:
// 9   7   1   
// 3   2   1   
// 6   5   4


// using System;

// public class Answer
// {
//     public static void PrintMatrix(int[,] matrix)
//     {
// // Введите свое решение ниже
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }   
//     }


//     public static void SortRowsDescending(int[,] matrix)
//     {
// // Введите свое решение ниже
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols - 1; j++)
//             {
//                 for (int k = 0; k < cols - j - 1; k++)
//                 {
//                     if (matrix[i, k] < matrix[i, k + 1])
//                     {
//                         // Обмен значениями
//                         int temp = matrix[i, k];
//                         matrix[i, k] = matrix[i, k + 1];
//                         matrix[i, k + 1] = temp;
//                     }
//                 }
//             }
//         }     

//     }


// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,] {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 if (elements.Length != matrix.GetLength(1))
//                 {
//                     Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
//                     return;
//                 }
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         SortRowsDescending(matrix);

//         Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
//         PrintMatrix(matrix);
//     }
// }




//---------------------------------------------------------------------------------------------


// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов
// в заданной строке row матрицы matrix. Метод принимает двумерный массив целых
// чисел matrix и номер строки row, а возвращает целое число - сумму элементов в
// данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей
// суммой элементов. Метод принимает двумерный массив целых чисел matrix и
// возвращает массив из двух элементов: номер строки с наименьшей суммой
// (нумерация начинается с 0) и саму сумму.

// Аргументы, передаваемые в метод/функцию:
// '9, 1, 7; 1, 2, 3; 4, 5, 6'

// На выходе:
// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Сумма наименьшей строки (строка 2): 6


// using System;

// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
// // Введите свое решение ниже
//         int sum = 0;
//         int cols = matrix.GetLength(1);

//         for (int j = 0; j < cols; j++)
//         {
//             sum += matrix[row, j];
//         }

//         return sum;
//     }

//     public static int[] MinimumSumRow(int[,] matrix)
//     {
// // Введите свое решение ниже
//         int rows = matrix.GetLength(0);
//         // int cols = matrix.GetLength(1);

//         int minSum = int.MaxValue;
//         int minSumRow = -1;

//         for (int i = 0; i < rows; i++)
//         {
//             int currentSum = SumOfRow(matrix, i);

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minSumRow = i;
//             }
//         }

//         return new int[] { minSumRow, minSum };
//     }

//  // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
//     }
// }


//---------------------------------------------------------------------------------------------



// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для
// проверки, возможно ли умножения двух матриц matrixA и matrixB. Если число
// столбцов в матрице matrixA не равно числу строк в матрице matrixB, то
// выводится сообщение "It is impossible to multiply." В противном случае,
// вызывается метод MatrixMultiplication для умножения матриц, и результат
// выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для
// умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу,
// которая представляет собой результат умножения матрицы matrixA на матрицу
// matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы по умолчанию. Если
// аргументы переданы, программа парсит их в двумерные массивы целых чисел и
// выполняет умножение матриц.

// Аргументы, передаваемые в метод/функцию:
// '1,2;3,4'

// На выходе:
// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50


using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);

        if (colsA != rowsB)
        {
            Console.WriteLine("It is impossible to multiply.");
            return;
        }

        int[,] result = MatrixMultiplication(matrixA, matrixB);

        PrintMatrix(result);
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}