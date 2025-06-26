using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;

public class Passenger: Human
{
   
    public bool HasTicket { get; set; }

    public Passenger(string name, bool hasTicket = false):base(name)
    {
       HasTicket = hasTicket;
    }
}