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
        string input = Console.ReadLine(); //допустим что может быть null

        if (double.TryParse(input, out double number)) // при вводе 77.7 или 77,7 говорит что не число
        {
            double absoluteValue = Math.Abs(number);
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
            Console.Write(i + " ");
        }
        Console.WriteLine(""); //чтоб следующее задание в консоли отобразилось красиво
    }

    static void Task3()
    {
        Console.WriteLine("Задача 3. Напишите здесь строку:");
        string? input = Console.ReadLine();
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--) 
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
        int N;
        string input = Console.ReadLine();

        if (int.TryParse(input, out N) && N >= 1 && N <= 10)
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Вводите число {i}:");
                int currentNumber;
                while (!int.TryParse(Console.ReadLine(), out currentNumber) || currentNumber < -10000 || currentNumber > 10000)
                {
                    Console.WriteLine("Ошибка! Введите целое число от -10000 до 10000:");
                }
            }
            Console.WriteLine("Все числа успешно введены!");
        }
        else Console.WriteLine("Ошибка! Введите целое число от 1 до 10:");
    }
    static void Task5()
    {
        Console.WriteLine("Задача 5. Введите целое число:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number)) //проверяем что введено целое число
        {
            if (number == 0) //если равно нулю
            {
                Console.Write("0");
            }
            else if (number > 0) //если больше нуля
            {
                for (int i = 0; i <= number; i++)
                {
                    Console.Write($"{i}, ");
                }
            }
            else // если меньше нуля
            {
                for (int i = 0; i >= number; i--)
                {
                    Console.Write($"{i}, ");
                }
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное значение");
        }
    }
}

