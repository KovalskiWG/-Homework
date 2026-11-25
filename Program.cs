// Для проверки задания введите название функции с соответсвующим номером ДЗ и задания из перечня:
// от  Task1_1   до   Task1_8
// от  Task2_1   до   Task2_4
// Task3_1



static void Task1_1()
{
    Console.WriteLine("Введите два целых числа.");
    int a = Convert.ToInt32( Console.ReadLine() );
    int b = Convert.ToInt32( Console.ReadLine() );

    if (a > b)
    {
        Console.WriteLine($"{a} больше чем {b}");
    } else if (a < b)
    {
        Console.WriteLine($"{b} больше чем {a}");
    } else
    {
        Console.WriteLine("числа равны");
    }
}


static void Task1_2()
{
    Console.WriteLine("Введите три целых числа.");
    int a = Convert.ToInt32( Console.ReadLine() );
    int b = Convert.ToInt32( Console.ReadLine() );
    int c = Convert.ToInt32( Console.ReadLine() );

    int max = Math.Max(a, Math.Max(b, c));
    Console.WriteLine($"Максимальное: {max}");    
}



static void Task1_3()
{
    Console.WriteLine("Введите целое число.");
    int a = Convert.ToInt32( Console.ReadLine() );

    if (a % 2 == 0)
    {
        Console.WriteLine($"{a} - четное");
    } else
    {
        Console.WriteLine($"{a} - нечетное");
    }    
}



static void Task1_4()
{
    Console.WriteLine("Введите целое число.");
    int a = Convert.ToInt32( Console.ReadLine() );

    for  (int i = 2; i <= a; i += 2)
    {
        Console.Write($"{i}, ");
    }
    
}


static void Task1_5()
{
    Console.WriteLine("Введите целое число.");
    int a = Convert.ToInt32( Console.ReadLine() );

    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine($"{a} кратен 7 и 23 одновременно");
    } else
    {
        Console.WriteLine($"{a} - НЕ кратен 7 и 23 одновременно");
    }    
}



static void Task1_6()
{
    Console.WriteLine("Введите целые координаты X и Y не равные 0.");
    int x = Convert.ToInt32( Console.ReadLine() );
    int y = Convert.ToInt32( Console.ReadLine() );

    if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine($"координата ({x}, {y}) находится в первом квадранте");
        }
        else
        {
            Console.WriteLine($"координата ({x}, {y}) находится в четвертом квадранте");
        }
    } else
    {
        if (y > 0)
        {
            Console.WriteLine($"координата ({x}, {y}) находится во втором квадранте");
        } else
        {
            Console.WriteLine($"координата ({x}, {y}) находится в третьем квадранте");
        }
    }    
}


static void Task1_7()
{
    Console.WriteLine("Введите целое число из отрезка [10, 99].");
    int x = Convert.ToInt32( Console.ReadLine() );
    int x1 = x % 10;
    int x2 = (x % 100 - x1) / 10;

    if (x1 > x2)
    {
        Console.WriteLine(x1);
    } else
    {
        Console.WriteLine(x2);
    }    
}



static void Task1_8()
{
    Console.WriteLine("Введите натуральное число.");
    string str = Console.ReadLine();

    for (int i = 0; i < str.Length; i++)
    {
        Console.Write( str[i] );

        if (i < str.Length - 1)
        {
            Console.Write(", ");
        }
    }    
}


static void Task2_1()
{
    Random random = new Random();

    int[] numbers = new int[10];
    int entry = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 101);
        Console.Write($"{numbers[i]} ");
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 20 && numbers[i] <= 90)
            entry++;
    }

    Console.WriteLine($"\n{entry} вхождений в интервал");    
}


static void Task2_2()
{
    Random random = new Random();

    int[] numbers = new int[10];
    int entry = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 101);
        Console.Write($"{numbers[i]} ");
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            entry++;
    }

    Console.WriteLine($"\n{entry} четных чисел");    
}



static void Task2_3()
{
    Random random = new Random();

    double[] numbers = new double[10];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(random.NextDouble() * 100, 3);
        Console.Write($"{numbers[i]} ");
    }

    double max = numbers[0];
    double min = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        max = Math.Max(max, numbers[i]);
        min = Math.Min(min, numbers[i]);
    }

    Console.WriteLine($"\nМаксимальное: {max}");
    Console.WriteLine($"Минимальное: {min}");
    Console.WriteLine($"Разница: {max - min}");    
}



static void Task2_4()
{
    Random random = new Random();

    int n = random.Next(1, 100001);
    string nToString = n.ToString();
    int[] numToArray = new int[nToString.Length];

    for (int i = 0; i < nToString.Length; i++)
    {
        numToArray[i] = nToString[i] - '0';
    }

    Console.WriteLine(n);

    for (int i = 0; i < numToArray.Length; i++)
    {
        Console.Write($"{numToArray[i]} ");
    }    
}



static void Task3_1()
{
    Random random = new Random();

    int[] numbers = new int[20];
    int even = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
        Console.Write($"{numbers[i]} ");
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            even++;
    }

    Console.WriteLine($"\n{even} четных чисел");    
}

Task3_1();