// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное 
// число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.

// static bool IsPalindrome(int number)
// {
    // int num1 = number / 10000;
    // int num2 = number / 1000 % 10;
    // int rev1 = number % 10;
    // int rev2 = number / 10 % 10;
    // if (number > 99999)
      // {
      // System.Console.WriteLine($"Число не пятизначное ");
      // return false;
      // }
    // else if (num1 == rev1 && num2 == rev2)
    // {
        // System.Console.Write("{number} -> ");
        // return true;
    // }
    // else
    // {
        // System.Console.Write("{number} -> ");
        // return false;
    // }
// }
    


// Внутри класса Answer напишите метод DistanceBetweenPoints, который
// принимает на вход координаты двух точек pointA и pointB в виде массива
// целых чисел, и возвращает расстояние между ними в 3D пространстве.


// System.Console.WriteLine("Напишите значение координат: ");
// double result = 0;
// System.Console.Write("Координата x pointА: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Координата y pointА: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Координата z pointА: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Координата x pointB: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Координата y pointB: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Координата z pointB: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// System.Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Round(result, 2)}");


// Может так?

// static double Length(int[] pointA, int[] pointB)
    // {
      // Введите свое решение ниже
      
     // int A = pointB[0] - pointA[0];
     // int B = pointB[1] - pointA[1];
     // int C = pointB[2] - pointA[2];

     // double result = Math.Sqrt(A * A + B * B + C * C);
     // return result;
    // }


// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и
// выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

static void ShowCube(int N)
    {
      // Введите свое решение ниже
      for (int i = 1; i <= N; i++)
      {
        Console.WriteLine($"{i * i * i}");
      }  
    }

