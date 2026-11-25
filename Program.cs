// Task1.1
// Console.WriteLine("Введите два целых числа.");
// int a = Convert.ToInt32( Console.ReadLine() );
// int b = Convert.ToInt32( Console.ReadLine() );

// if (a > b)
// {
//     Console.WriteLine($"{a} больше чем {b}");
// } else if (a < b)
// {
//     Console.WriteLine($"{b} больше чем {a}");
// } else
// {
//     Console.WriteLine("числа равны");
// }

// Task1.2
// Console.WriteLine("Введите три целых числа.");
// int a = Convert.ToInt32( Console.ReadLine() );
// int b = Convert.ToInt32( Console.ReadLine() );
// int c = Convert.ToInt32( Console.ReadLine() );

// int max = Math.Max(a, Math.Max(b, c));
// Console.WriteLine($"Максимальное: {max}");


// Task 1.3
// Console.WriteLine("Введите целое число.");
// int a = Convert.ToInt32( Console.ReadLine() );

// if (a % 2 == 0)
// {
//     Console.WriteLine($"{a} - четное");
// } else
// {
//     Console.WriteLine($"{a} - нечетное");
// }


// Task 1.4
// Console.WriteLine("Введите целое число.");
// int a = Convert.ToInt32( Console.ReadLine() );

// for  (int i = 2; i <= a; i += 2)
// {
//     Console.Write($"{i}, ");
// }


// Task 1.5
Console.WriteLine("Введите целое число.");
int a = Convert.ToInt32( Console.ReadLine() );

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"{a} кратен 7 и 23 одновременно");
} else
{
    Console.WriteLine($"{a} - НЕ кратен 7 и 23 одновременно");
}


// Task 1.6
// Console.WriteLine("Введите целые координаты X и Y не равные 0.");
// int x = Convert.ToInt32( Console.ReadLine() );
// int y = Convert.ToInt32( Console.ReadLine() );

// if (x > 0)
// {
//     if (y > 0)
//     {
//         Console.WriteLine($"координата ({x}, {y}) находится в первом квадранте");
//     }
//     else
//     {
//         Console.WriteLine($"координата ({x}, {y}) находится в четвертом квадранте");
//     }
// } else
// {
//     if (y > 0)
//     {
//         Console.WriteLine($"координата ({x}, {y}) находится во втором квадранте");
//     } else
//     {
//         Console.WriteLine($"координата ({x}, {y}) находится в третьем квадранте");
//     }
// }

// Task 1.7
// Console.WriteLine("Введите целое число из отрезка [10, 99].");
// int x = Convert.ToInt32( Console.ReadLine() );
// int x1 = x % 10;
// int x2 = (x % 100 - x1) / 10;

// if (x1 > x2)
// {
//     Console.WriteLine(x1);
// } else
// {
//     Console.WriteLine(x2);
// }


// Task 1.8
// Console.WriteLine("Введите натуральное число.");
// string str = Console.ReadLine();

// for (int i = 0; i < str.Length; i++)
// {
//     Console.Write( str[i] );

//     if (i < str.Length - 1)
//     {
//         Console.Write(", ");
//     }
// }