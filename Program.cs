void Task01()
{
    System.Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    PrintNumbers(n);

    void PrintNumbers(int n)
    {
        if (n == 0) return;
        else
        {
            PrintNumbers(n - 1);
            System.Console.Write(n + " ");
        }
    }
}

void Task02()
{
    System.Console.WriteLine("Введите два числа. Второе должно быть больше первого.");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = SumOfNumbers(m, n);
    System.Console.WriteLine($"Сумма элементов между этими числами равна {sum}");
    int SumOfNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        return m + SumOfNumbers(m + 1, n);
    }
}

void Task03()
{
    System.Console.WriteLine("Введите два неотрицательных числа.");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int result = Ackermann(m, n);
    System.Console.WriteLine($"Результат: {result}");
    int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}


System.Console.WriteLine("Введите номер задачи, где: \n 1 - натуральные числа от 1 до N \n 2 - сумма натуральных элементов от М до N \n 3 - функция Аккермана");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{
    case 1:
        Task01();
        break;
    case 2:
        Task02();
        break;
    case 3:
        Task03();
        break;
    default:
        System.Console.WriteLine("Такой задачи нет");
        break;
}