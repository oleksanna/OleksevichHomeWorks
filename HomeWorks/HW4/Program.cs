
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// double DigitPow(double A, double B)
// {
//     return Math.Pow(A, B);
// }

// System.Console.Write("Input A: ");
// double a = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Input B: ");
// double b = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine(DigitPow(a, b));




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int len = Length(n);
// System.Console.WriteLine($"{n} -> {Sum(n, len)}");

// int Length (int n)
// {
//     int index = 0;
//     while (n > 0)
//     {
//         n /= 10;
//         index++;
//     }
//     return index;
// }
    
// int Sum(int n, int len)    
// {    
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n%10;
//         n /= 10;
//     }
//     return sum;
// }




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] RandomArray(int size, int minValue, int maxValue)
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
//         System.Console.Write(array[i]+ " ");
//     }
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(RandomArray(size, min, max));
