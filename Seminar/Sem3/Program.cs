// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равно 0 и Y не равно 0 и выдает номнр четверти плоскости,
// в которой ноходится эта точка.

// int FindQuarter(int x, int y)
// {
    // if(x>0 && y>0) return 1;
    // if(x<0 && y>0) return 2;
    // if(x<0 && y<0) return 3;
    // if(x>0 && y<0) return 4;
    // return 0;
// }

// System.Console.Write("Input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindQuarter(x, y));



// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1, 4.


// void QuadTable(int n)
// {
    // int current = 1;
    // while(current <= n)
    // {
        // System.Console.Write(current * current + ", ");
        // current++;
    // }
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// QuadTable(n);


// Или так


// void QuadTable(int n)
// {
    // int current = 1;
    // System.Console.Write(n + "-> ");
    // while(current < n)
    // {
        // System.Console.Write(current * current + ", ");
        // current++;
    // }
    // System.Console.Write(current * current);
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// QuadTable(n);



