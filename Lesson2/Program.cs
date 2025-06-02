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
        Console.WriteLine("Задача 1:");
        //записываем в массив 15 чисел фиббоначе
        int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine("");
    }

    static void Task2()
    {
        int[] numbers = new int[7];

        Console.WriteLine("Введите 7 целых чисел через запятую (например: 2, 2, 2, 4, 6, 7, 7):");

        // Получаем ввод от пользователя
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(','); // убираем запятые из ввода

        // Проверяем, что введено ровно 7 чисел
        if (inputNumbers.Length != 7)
        {
            Console.WriteLine("Ошибка! Нужно ввести ровно 7 чисел.");
            return;
        }
        // Создаем словарь для подсчета количества чисел
        Dictionary<int, int> numberCounts = new Dictionary<int, int>();

        // Подсчитываем количество каждого числа
        foreach (int num in numbers)
        {
            if (numberCounts.ContainsKey(num))
            {
                numberCounts[num]++;
            }
            else
            {
                numberCounts[num] = 1;
            }
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        bool first = true;
        foreach (var pair in numberCounts)
        {
            if (!first)
            {
                Console.Write(", ");
            }
            Console.Write($"{pair.Key} ({pair.Value})");
            first = false;
        }

    }

    static void Task3()
    {
        
    }

    static void Task4()
    {
    }

    static void Task5()
    {
    }
}

