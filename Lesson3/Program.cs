using Lesson3;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // создаем трех водителей
        Driver driver1 = new("Кирилл Соснин") { LicenseNumber = "99ФАР" };  
        Driver driver2 = new("Макар Крюков") { LicenseNumber = "999ЛА" };  
        Driver driver3 = new("Кузьма Хорошев") { LicenseNumber = null }; 

        // создаем кондуктора
        Conductor conductor = new("Катерина Измайлова");

        // создаем два автобуса
        Bus bus1 = new(101, driver1)
        {
            Conductor = conductor
        };

        driver2.LicenseNumber = "99ЛАК";
        Bus bus2 = new(202, driver2);

        // выводим информацию об экипажах
        PrintInfo(bus1);
        PrintInfo(bus2);
    }
    //метод для вывода информации
    static void PrintInfo(Bus bus)
    {
        Console.Write($"Автобус {bus.GarageNumber}. Водитель: {bus.Driver.Name}");

        if (bus.Conductor != null)
        {
            Console.WriteLine($". Кондуктор: {bus.Conductor.Name}");
        }
        else
        {
            Console.WriteLine();
        }
    }
}