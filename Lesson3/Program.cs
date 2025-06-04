using Lesson3;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем трех водителей
        Driver driver1 = new Driver("Кирилл Соснин") { LicenseNumber = "99ФАР" };  
        Driver driver2 = new Driver("Макар Крюков") { LicenseNumber = "999ЛА" };  
        Driver driver3 = new Driver("Кузьма Хорошев") { LicenseNumber = null }; 

        // Создаем кондуктора
        Conductor conductor = new Conductor("Катерина Измайлова");

        // Создаем два автобуса
        Bus bus1 = new Bus(101, driver1);  
        bus1._conductor = conductor;

        driver2.LicenseNumber = "99ЛАК";
        Bus bus2 = new Bus(202, driver2);

        // Выводим информацию об экипажах
        PrintCrewInfo(bus1);
        PrintCrewInfo(bus2);
    }

    static void PrintCrewInfo(Bus bus)
    {
        Console.Write($"Автобус {bus.GarageNumber}. Водитель: {bus.Driver.Name}");

        if (bus._conductor != null)
        {
            Console.WriteLine($". Кондуктор: {bus._conductor.Name}");
        }
        else
        {
            Console.WriteLine();
        }
    }
}