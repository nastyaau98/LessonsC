using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;

public class Passenger
{
    public string Name { get; }
    public bool HasTicket { get; set; }

    public Passenger(string name, bool hasTicket = false)
    {
        Name = name;
        HasTicket = hasTicket;
    }
}