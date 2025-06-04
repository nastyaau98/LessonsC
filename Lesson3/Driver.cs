namespace Lesson3;

public class Driver
{
    // Свойство "Имя водителя"
    public string Name { get; }

    // Свойство "Номер водительского удостоверения"
    public string? LicenseNumber { get; set; }

    // Конструктор, принимающий имя
    public Driver(string name)
    {
        Name = name;
    }

    // Метод проверки валидности ВУ
    public bool IsLicenseValid()
    {
       if (string.IsNullOrEmpty(LicenseNumber))
            return false;

        // Проверяем длину (должно быть 5 символов)
        if (LicenseNumber.Length != 5)
            return false;

        // Проверяем, что удостоверение состоит из 2 цифр и 3 заглавных букв
        int digitCount = 0;
        int letterCount = 0;

        foreach (char c in LicenseNumber)
        {
            if (char.IsDigit(c)) //является ли цифрой
                digitCount++;
            else if (char.IsLetter(c)&& char.IsUpper(c)) //является ли буквой и заглавной
                letterCount++;
            else
                return false; // Недопустимый символ
        }
        return digitCount == 2 && letterCount == 3;
    }
}

