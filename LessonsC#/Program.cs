namespace Lesson1;
public class Lesson1
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    static void Task1()
    {
        Console.WriteLine("Введите число от - 10 000 до 10 000:");
        string? input = Console.ReadLine(); //допустим что может быть null

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
        Console.WriteLine("Я вывожу все четные числа от 0 до 100");
        for (int i = 0; i <= 100; i++)
        {
            Console.Write(i + " ");
            Console.WriteLine(""); //чтоб следующее задание в консоли отобразилось красиво
        }
    }

    static void Task3()
    {
        Console.WriteLine("Напишите здесь строку:");
        string? input = Console.ReadLine();
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--) //через for т.к. строка - массив символов, с массивами в следующем дз)
        {
            reversed += input[i];
        }
        Console.WriteLine("Вот ваша строка в обратном порядке:");
        Console.WriteLine(reversed);
    }
    static void Task4()
    {
        Console.WriteLine("Введите целое число:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number)) //проверяем что введено целое число
        {
            if (number == 0) //если равно нулю
            {
                Console.WriteLine("0");
            }
            else if (number > 0) //если больше нуля
            {
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else // если меньше нуля
            {
                for (int i = 0; i >= number; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное значение");
        }
    }
}

