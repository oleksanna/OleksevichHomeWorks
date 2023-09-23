// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num < 1000)
// {
    // int dec = num / 10;
    // int sec = dec % 10;
    // System.Console.WriteLine($"Second digit of {num} -> {sec}");
// }
// else
// {
   // System.Console.WriteLine("You input not tree-digit number"); 
// }

// Лучше так...

// System.Console.WriteLine("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void secondDigit(int num)
// {
// if(num >= 100 && num < 1000)
// {
    // int dec = num / 10;
    // int sec = dec % 10;
    // System.Console.WriteLine($"Second digit of {num} -> {sec}");
// }
// else
// {
   // System.Console.WriteLine("You input not tree-digit number"); 
// }
// }
// secondDigit(num);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// while (num > 999)
// {
   // num = num / 10; 
// }
// if(num >= 100 && num < 1000)
// {
    // int ed = num % 10;
    // System.Console.WriteLine($"Three digit of {num} -> {ed}");
// }
// else
// {
    // System.Console.WriteLine($"Second digit of {num} -> третьей цифры нет");
// }

// Лучше так ...

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// treeDigit(num);
// void treeDigit (int num)
// {
     // System.Console.Write($"{num}");
// while (num > 999)
// {
   // num = num / 10;
// }
// if(num >= 100 && num < 1000)
// {
    // int ed = num % 10;
    // System.Console.Write($"-> {ed}");
// }
// else
// {
    // System.Console.WriteLine($" -> третьей цифры нет");
// }
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// System.Console.Write("Введите номер дня недели : ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num > 0 && num < 8)
// {
    // if(num > 5)
    // {
        // System.Console.WriteLine($"{num} -> Да ");
    // }
    // else
    // {
        // System.Console.WriteLine($"{num} -> Нет");
    // }
// }
// else
// {
    // System.Console.WriteLine($"{num} -> Нет такого дня недели");
// }

// Лучше так ...

System.Console.Write("Введите номер дня недели : ");
int num = Convert.ToInt32(Console.ReadLine());
weekDay(num);

void weekDay(int num)
{
if(num > 0 && num < 8)
{
    if(num > 5)
    {
        System.Console.WriteLine($"{num} -> Выходной! ");
    }
    else
    {
        System.Console.WriteLine($"{num} -> Рабочий день");
    }
}

else
{
    System.Console.WriteLine($"{num} -> Нет такого дня недели");
}
}

