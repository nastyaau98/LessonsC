using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3;
// Базовый класс "Человек"
public class Human
{
    public string Name { get; } // Имя можно задать только из конструктора

    public Human(string name)
    {
        Name = name;
    }
}
