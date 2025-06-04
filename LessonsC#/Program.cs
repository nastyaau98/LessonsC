namespace Lesson1;
public class Lesson1
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }

    static void Task1()
    {
        Console.WriteLine("Задача 1. Введите число от - 10 000 до 10 000:");
        string? input = Console.ReadLine(); //допустим что может быть null

        if (int.TryParse(input, out int number))
        {
            int absoluteValue = Math.Abs(number);
            Console.WriteLine($"Модулем числа {number} является {absoluteValue}");
        }
        else
        {
            Console.WriteLine("Ошибка: введено не число!");
        }
    }

    static void Task2()
    {
        Console.WriteLine("Задача 2. Я вывожу все четные числа от 0 до 100");
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine(""); //чтоб следующее задание в консоли отобразилось красиво
    }

    static void Task3()
    {
        Console.WriteLine("Задача 3. Напишите здесь строку:");
        string? input = Console.ReadLine();
        string reversed = "";
        for (int i = input!.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine("Вот ваша строка в обратном порядке:");
        Console.WriteLine(reversed);
    }

    static void Task4()
    {
        // Запрашиваем число N (от 1 до 10)
        Console.WriteLine("Задача 4. Введите число N (от 1 до 10):");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 10)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите число:");
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < -10000 || currentNumber > 10000)
                {
                    Console.WriteLine("Ошибка! Введено число вне диапазона от -10000 до 10000:");
                }
            }
            Console.WriteLine("Все числа введены:))");
        }
        else Console.WriteLine("Ошибка! Введено число вне диапазона от 1 до 10");
    }
    static void Task5()
    {
        Console.WriteLine("Задача 5. Введите целое число:");
        int? number = int.Parse(Console.ReadLine());

        if (number % 1 == 0) //проверяем что введено целое число
        {
            switch (number)
            {
                case 0:
                    Console.Write("0");
                    break;
                case > 0:
                    for (int i = 0; i <= number; i++)
                    {
                        Console.Write($"{i}, ");
                    }
                    break;
                case < 0:
                    for (int i = 0; i >= number; i--)
                    {
                        Console.Write($"{i}, ");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введено не целое число!");
        }
    }
}

