﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;
public interface IPassengerTransport
{
    // Список пассажиров
    List<Passenger> Passengers { get; }
}

