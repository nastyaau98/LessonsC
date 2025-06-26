namespace Lesson3;

public interface IElectricTransport
{
    // Свойство "Оставшийся заряд" (можно задавать только внутри класса)
    float RemainingCharge { get; }

    // Метод для зарядки (увеличивает заряд на указанное значение)
    void Charge(float amount);
}
