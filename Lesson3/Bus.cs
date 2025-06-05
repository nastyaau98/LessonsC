namespace Lesson3;

public class Bus
{
    public int GarageNumber { get; } // Гаражный номер 
    public Driver _driver; // Поле для хранения водителя
    public Conductor? Conductor; // Кондуктор
    public List<Passenger> _passengers; // Список пассажиров
    public int Mileage { get; set; } // Километраж

    // Свойство "Водитель" с проверкой валидности удостоверения
    public Driver Driver
    {
        get => _driver;
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Водитель не может быть null");

            if (!value.IsLicenseValid())
                throw new ArgumentException("У водителя недействительное удостоверение");

            _driver = value;
        }
    }

    // Конструктор класса
    public Bus(int garageNumber, Driver driver)
    {
        GarageNumber = garageNumber;
        Driver = driver; 
        _passengers = [];
        Mileage = 0;
    }
}
