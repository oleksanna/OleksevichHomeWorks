// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Your number -> {num} ");

// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {num} -> {num*num}");


// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    
//  456 -> 6
    
//  782 -> 2
    
//  918 -> 8

System.Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num < 1000)
{
    System.Console.WriteLine($"Last digit of {num} -> {num%10}");
}
else
{
   System.Console.WriteLine("You input not tree-digit number"); 
}



// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// int i = -1*num;
// while (i<=num)
// {
    // System.Console.WriteLine(i++);
// }


// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// System.Console.WriteLine("Ввдеите число А: ");
// int numA = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите число В: ");
// int numB = Convert.ToInt32(System.Console.ReadLine());
// if (numB*numB == numA)
// {
    // System.Console.WriteLine($"a={numA}; b={numB} -> Да");
// }
// else
// {
    // System.Console.WriteLine($"a={numA}; b={numB} -> Нет");
// }