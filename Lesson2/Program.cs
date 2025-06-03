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
        //переворачиваем последовательность при выводе в консоль
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine("");
    }

    static void Task2()
    {
        int[] numbers = [];
        for (int i = 0; i < 1;) //цикл чтоб можно было повторно ввести данные после ошибки
        {
            Console.WriteLine("Введите 7 целых чисел через запятую:");

            // Получаем ввод от пользователя
            string input = Console.ReadLine();
            string[] inputNumbers = input!.Split(','); // убираем запятые из строки 
            // Проверяем, что введено ровно 7 чисел
            if (inputNumbers.Length != 7)
            {
                Console.WriteLine("Ошибка! Ввели не 7 чисел.");
            }
            else
            {
                bool isAllCount = true;
                foreach (string number1 in inputNumbers) //проверяем что можем перевести из string в int
                {
                    bool success = int.TryParse(number1, out int result);
                    if (success == false) { isAllCount = false; break; }
                }
                if (isAllCount == false)
                {
                    Console.WriteLine("Ошибка: введите только числа");
                }
                else
                {
                    numbers = inputNumbers.Select(int.Parse).ToArray();//переводим из string в int
                    i = 1;
                }
            }
        }

        // Создаем словарь для подсчета количества чисел
        Dictionary<int, int> numberCounts = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            numberCounts.TryGetValue(num, out int count); //присваиваем значение ключу и считаем
            numberCounts[num] = count + 1;
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (var pair in numberCounts)
        {
            Console.Write($"{pair.Key} ({pair.Value}) , ");
        }
    }

    static void Task3()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Введите 10 целых чисел:");

        // Запрашиваем у пользователя 10 чисел
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                i--; // Повторяем запрос при ошибке
            }
        }

        // Находим и выводим минимальное и максимальное значения
        int min = numbers.Min();
        int max = numbers.Max();
        Console.WriteLine($"Минимальное значение: {min}");
        Console.WriteLine($"Максимальное значение: {max}");

        // Удаляем минимальное и максимальное значения
        numbers.Remove(min);
        numbers.Remove(max);

        // Выводим список в обратном порядке
        Console.WriteLine("Список после удаления значений (в обратном порядке):");
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static void Task4()
    {
        // Создаем массив из 5 целых чисел
        int[] array = new int[5];

        Console.WriteLine("Введите 5 целых чисел:");

        // Заполняем массив числами от пользователя
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Число {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                Console.Write($"Число {i + 1}: ");
            }
        }

        // Создаем списки для положительных и отрицательных чисел
        List<int> positiveNumbers = new List<int>();
        List<int> negativeNumbers = new List<int>();

        // Добавляем числа в списки
        foreach (int num in array)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
            else if (num < 0)
            {
                negativeNumbers.Add(num);
            }
        }

        // Подсчитываем нули (через списки)
        int zeroCount = array.Length - positiveNumbers.Count - negativeNumbers.Count;

        // Выводим результаты
        Console.WriteLine($"Количество нулей: {zeroCount}");
        Console.WriteLine("Все положительные числа из массива:");
        foreach (int num in positiveNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("Все отрицательные числа из массива:");
        foreach (int num in negativeNumbers)
        {
            Console.WriteLine(num);
        }
    }

    static void Task5()
    {
        // Создаем и заполняем множество
        HashSet<int> numbersSet = new HashSet<int> { 1, 9, 8, -7, -6 };

        // Создаем список для трех чисел
        List<int> userNumbers = new List<int>();
        Console.WriteLine("Введите 3 целых числа в диапазоне от -10 до 10:");

        //заполняем список
        for (int i = 0; i < 3; i++)
        {
            int number;
            while (true)
            {
                Console.Write($"Число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > -10 && number < 10)
                {
                    userNumbers.Add(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Число должно быть целым в диапазоне (-10;10).");
                }
            }
        }

        // Создаем и заполняем словарь
        Dictionary<int, bool> numbersDict = new Dictionary<int, bool>();
        foreach (int num in userNumbers)
        {
            numbersDict[num] = numbersSet.Contains(num);
        }

        // Выводим результаты
        Console.WriteLine("Результаты:");
        foreach (var pair in numbersDict)
        {
            Console.WriteLine($"Число: {pair.Key}; Есть во множестве: {pair.Value};");
        }
    }
}

