namespace Lesson3;

public class Driver : Human
{
    
    // Свойство "Номер водительского удостоверения"
    public string? LicenseNumber { get; set; }

    // Конструктор, принимающий имя
    public Driver(string name) : base(name)
    {
    }

    // Метод проверки валидности ВУ
    public bool LicenseValidation()
    {
       if (string.IsNullOrEmpty(LicenseNumber))
            return false;

        // Проверяем длину (должно быть 5 символов)
        if (LicenseNumber.Length != 5)
            return false;

        // Проверяем, что удостоверение состоит из 2 цифр и 3 заглавных букв
        var digitCount = 0;
        var letterCount = 0;

        foreach (var c in LicenseNumber)
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

