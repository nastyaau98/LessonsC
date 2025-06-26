using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;

public class CityBus : Bus, IConductorTransport
{

    //Реализация IConductorTransport
    Conductor? IConductorTransport.Conductor
    {
        get => base.Conductor;  // Используем свойство из Bus
        set => base.Conductor = value;
    }
    public CityBus(int garageNumber, Driver driver) : base(garageNumber, driver)
    {
    }
}