// Напишите программу. которая принимает на вход число и выдает
// количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

// int DigitCount(int num)
// {
//     int count = 0;
//     for (int i = 1; Math.Abs(num) > 0; i++)
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

// Напишите программу, которая выводит массив со скольки угодно значениями,
//  заполненными рандомными значениями в указанном диапазоне 

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CreateRandomArray(size, min, max));



// Но для вывода значений нужно так!!!



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
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, min, max));



// Напишите программу, которая принимает на вход число (А) и 
// выдает сумму чисел от 1 до А.

// 7 -> 28

// 4 -> 10

// 8 -> 36



// int GetSumNumbers(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// System.Console.Write("Input A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(GetSumNumbers(A));



// Напишите программу, которая принимает на вход число (А) и 
// выдает факториал чисела А.


int FindFactorial(int A)
{
    int fact = 1;
    for (int i = 1; i <= A; i++)
    {
        fact *= i;
    }
    return fact;
}

System.Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindFactorial(A));
