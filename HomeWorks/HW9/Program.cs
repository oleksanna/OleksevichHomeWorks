﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNums(int n)
// {
//     if (n > 0)
//     {
//         System.Console.Write(n + " ");
//         ShowNums(n - 1);        
//     }
// }

// ShowNums(7);

//------------------------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumNaturalNumbers(int m, int n)
//     {        
//         if (m > n)
//         {
//             return 0;
//         }
//         return m + SumNaturalNumbers(m + 1, n);
//     }

// Console.Write(SumNaturalNumbers(10,15));

//-----------------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }

    return 0;
}

Console.Write(Ackerman(3,2));