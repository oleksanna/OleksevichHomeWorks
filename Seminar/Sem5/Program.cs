﻿// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine(); // Разделительная строка
// }

// void PosNegSum(int[] array)
// {
//     int positiveSum = 0;
//     int negativeSum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             positiveSum += array[i];
//         }
//         else
//         {
//             negativeSum += array[i];
//         }
//     }
//     System.Console.Write($"Sum of positive array elements -> {positiveSum}\nSum of negative array elements -> {negativeSum}"); 
// }                // сочетание \n когда нужно вывести и то и другое...

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max); // Чтоб выводил массив и в нем же считал
// PrintArray(myArray);
// PosNegSum(myArray);

//-----------------------------------------------------------------------------------

// **Задача 35:** Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке ([10, 99]) !!! Запрашиваемых значений... двухзначные или трехзначныие и т.д.

// *Пример для массива из 5 , а не 123 элементов. 
// В своем решении сделайте для 123*

// [5, 18, 123, 6, 2] -> 1
// [10, 11, 12, 13, 14] -> 5



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine(); // Разделительная строка
// }

// int ElementsCounter(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= min && array[i] <= max)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input lower bound: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input upper bound: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue); // Чтоб выводил массив и в нем же считал
// PrintArray(myArray);
// System.Console.WriteLine(ElementsCounter(myArray, min, max));

// ------------------------------------------------------------------------------
// Задача 33: Задайте массив . Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [10, 11, 12, 13, 14] -> да


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine(); // Разделительная строка
// }

// bool FindElement(int[]array, int n)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (n == array[i])
//         return true;
//     }
//     return false;
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max); // Чтоб выводил массив и в нем же считал
// PrintArray(myArray);

// System.Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindElement(myArray, n));

//---------------------------------------------------------------------------------------

// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(); // Разделительная строка
}

int[] MirrorNumbersInArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max); // Чтоб выводил массив 
System.Console.Write("Изначальный массив -> ");
PrintArray(myArray);

int[] mirrorArray = MirrorNumbersInArray(myArray); // Чтоб выводил измененный массив 
System.Console.Write("Зеркальный массив -> ");
PrintArray(mirrorArray);
