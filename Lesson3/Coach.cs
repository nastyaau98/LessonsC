// Класс Коуч
using Lesson3;
public class Coach : Bus
{
    public int FreeSeats { get; set; }  // Количество свободных мест

    public Coach(int garageNumber, Driver driver) : base(garageNumber, driver)
    {
    }
}

