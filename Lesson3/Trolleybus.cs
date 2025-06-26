namespace Lesson3;

public class Trolleybus : Bus, IElectricTransport, IConductorTransport
{
    public int Voltage { get; set; }  // Напряжение
    private float remainingCharge;

    // Реализация IElectricTransport
    public float RemainingCharge
    {
        get => remainingCharge;
        private set => remainingCharge = value;
    }
    public void Charge(float amount)
    {
        if (amount < 0)
            throw new ArgumentException("Количество заряда не может быть отрицательным");
        remainingCharge += amount;
    }

    //Реализация IConductorTransport
    Conductor? IConductorTransport.Conductor
    {
        get => base.Conductor;  // Используем свойство из Bus
        set => base.Conductor = value;
    }

    // Конструктор
    public Trolleybus(int garageNumber, Driver driver) : base(garageNumber, driver)
    {
    }
}
