
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Ввдеите число А: ");
// int numA = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите число В: ");
// int numB = Convert.ToInt32(System.Console.ReadLine());
// if(numA > numB)
// {
   //  System.Console.WriteLine($"a = {numA}, b = {numB} -> max = {numA}");
// }
// else
// {
    // System.Console.WriteLine($"a = {numA}, b = {numB} -> max = {numB}");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Ввдеите число А: ");
// int numA = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите число В: ");
// int numB = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Ввдеите число C: ");
// int numC = Convert.ToInt32(System.Console.ReadLine());

// int max = numA;

// if(numA > max) max = numA;
// if(numB > max) max = numB;
// if(numC > max) max = numC;

// System.Console.WriteLine($"{numA}, {numB}, {numC} -> {max}");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());

// if (num%2 == 0)
// {
  // System.Console.WriteLine($"{num} -> да");  
// }
// else
// {
    // System.Console.WriteLine($"{num} -> нет"); 
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(System.Console.ReadLine());
int i = 1;

while(i <= numN)
{
    System.Console.WriteLine(i++);
}