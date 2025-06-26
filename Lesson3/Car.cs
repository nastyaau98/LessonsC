using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Car
    {
        public int GarageNumber { get; }  // Гаражный номер (только для чтения)
        public int Mileage { get; set; }  // Километраж

        private Driver driver;

        // Свойство "Водитель" с проверкой валидности удостоверения
        public Driver Driver
        {
            get => driver;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "Водитель не может быть null");

                if (!value.LicenseValidation())
                    throw new ArgumentException("У водителя недействительное удостоверение");

                driver = value;
            }
        }

        public Car(int garageNumber, Driver driver)
        {
            GarageNumber = garageNumber;
            Driver = driver;  // Проверка выполнится через свойство
        }
    }

}
