using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;

public class Conductor
{
    public string Name { get; } //Имя
    public int TicketsIssued { get; set; } //Выданные билеты
    public Conductor(string name)
    {
        Name = name;
        TicketsIssued = 0;
    }
}
