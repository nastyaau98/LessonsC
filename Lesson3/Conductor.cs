namespace Lesson3;

public class Conductor : Human
{
    public int TicketsIssued { get; set; } //Выданные билеты
    public Conductor(string name) : base(name)
    {
        TicketsIssued = 0;
    }
}
