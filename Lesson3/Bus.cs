namespace Lesson3;

public class Bus:Car , IPassengerTransport
{
    
    public Conductor? Conductor; // Кондуктор
    public List<Passenger> Passengers { get; set; } // Список пассажиров

    // Конструктор класса
    public Bus(int garageNumber, Driver driver) : base(garageNumber, driver)
    {
        Passengers = [];
    }
}
